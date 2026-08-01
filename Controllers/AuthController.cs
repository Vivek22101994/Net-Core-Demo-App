using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    /// <summary>
    /// API Controller for handling JWT authentication and token generation
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class AuthController : ControllerBase
    {
        private readonly IJwtTokenService _jwtTokenService;
        private readonly IPasswordHasher<UsrAdmin> _passwordHasher;
        private readonly MyDbContext _dbContext;
        private readonly ILogger<AuthController> _logger;

        /// <summary>
        /// Initialize the AuthController with required dependencies
        /// </summary>
        public AuthController(
            IJwtTokenService jwtTokenService,
            IPasswordHasher<UsrAdmin> passwordHasher,
            MyDbContext dbContext,
            ILogger<AuthController> logger)
        {
            _jwtTokenService = jwtTokenService ?? throw new ArgumentNullException(nameof(jwtTokenService));
            _passwordHasher = passwordHasher ?? throw new ArgumentNullException(nameof(passwordHasher));
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Authenticate user and generate JWT token
        /// </summary>
        /// <param name="request">Login credentials (username and password)</param>
        /// <returns>JWT token response with user information</returns>
        /// <response code="200">Returns the generated JWT token</response>
        /// <response code="400">Invalid request or missing credentials</response>
        /// <response code="401">Invalid credentials or user not found</response>
        /// <response code="500">Internal server error</response>
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<JwtTokenResponse>> Login([FromBody] JwtTokenRequest request)
        {
            // Validate request
            if (request == null || string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
            {
                _logger.LogWarning("Login attempt with missing credentials");
                return BadRequest(new { message = "Username and password are required" });
            }

            try
            {
                // Find user in database by UserName or Login
                UsrAdmin? user = null;

                user = await _dbContext.USR_ADMIN
                    .FirstOrDefaultAsync(u => u.UserName == request.Username);

                if (user == null)
                {
                    user = await _dbContext.USR_ADMIN
                        .FirstOrDefaultAsync(u => u.Login == request.Username);
                }

                if (user == null)
                {
                    user = await _dbContext.USR_ADMIN
                        .FirstOrDefaultAsync(u => u.Email == request.Username);
                }

                if (user == null)
                {
                    _logger.LogWarning($"Login attempt for non-existent user: {request.Username}");
                    return Unauthorized(new { message = "Invalid username or password" });
                }

                // Verify password - direct comparison
                // TODO: In production, implement proper password hashing with BCrypt or similar
                var isPasswordValid = user.Password == request.Password;

                if (!isPasswordValid)
                {
                    _logger.LogWarning($"Failed login attempt for user: {request.Username}");
                    return Unauthorized(new { message = "Invalid username or password" });
                }

                // Generate JWT token
                var tokenResponse = _jwtTokenService.GenerateToken(user);

                _logger.LogInformation($"User successfully authenticated: {user.UserName}");

                return Ok(tokenResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error during login: {ex.Message}");
                return StatusCode(500, new { message = "An error occurred during authentication", error = ex.Message });
            }
        }

        /// <summary>
        /// Validate an existing JWT token
        /// </summary>
        /// <param name="token">The JWT token to validate</param>
        /// <returns>Token validation result with user claims</returns>
        /// <response code="200">Token is valid</response>
        /// <response code="401">Token is invalid or expired</response>
        [HttpPost("validate")]
        [AllowAnonymous]
        public ActionResult<object> ValidateToken([FromBody] string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return BadRequest(new { message = "Token is required" });
            }

            try
            {
                var principal = _jwtTokenService.ValidateToken(token);

                if (principal == null)
                {
                    _logger.LogWarning("Token validation failed");
                    return Unauthorized(new { message = "Invalid or expired token" });
                }

                var claims = principal.Claims.Select(c => new { c.Type, c.Value }).ToList();

                return Ok(new { message = "Token is valid", claims });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error validating token: {ex.Message}");
                return StatusCode(500, new { message = "An error occurred during token validation", error = ex.Message });
            }
        }

        /// <summary>
        /// Get current user information (requires authentication)
        /// </summary>
        /// <returns>Current authenticated user information</returns>
        /// <response code="200">Returns current user information</response>
        /// <response code="401">User is not authenticated</response>
        [HttpGet("me")]
        [Authorize]
        public ActionResult<object> GetCurrentUser()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var userName = User.FindFirst(System.Security.Claims.ClaimTypes.Name)?.Value;
                var userEmail = User.FindFirst(System.Security.Claims.ClaimTypes.Email)?.Value;

                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized(new { message = "User information not found in token" });
                }

                return Ok(new
                {
                    id = userId,
                    username = userName,
                    email = userEmail
                });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving current user: {ex.Message}");
                return StatusCode(500, new { message = "An error occurred retrieving user information", error = ex.Message });
            }
        }

        /// <summary>
        /// Refresh JWT token (requires valid current token)
        /// </summary>
        /// <returns>New JWT token</returns>
        /// <response code="200">Returns the new JWT token</response>
        /// <response code="401">User is not authenticated or token is invalid</response>
        [HttpPost("refresh")]
        [Authorize]
        public async Task<ActionResult<JwtTokenResponse>> RefreshToken()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

                if (string.IsNullOrEmpty(userId) || !int.TryParse(userId, out int id))
                {
                    return Unauthorized(new { message = "Invalid user information in token" });
                }

                var user = await _dbContext.USR_ADMIN.FindAsync(id);

                if (user == null)
                {
                    return Unauthorized(new { message = "User not found" });
                }

                var tokenResponse = _jwtTokenService.GenerateToken(user);

                _logger.LogInformation($"Token refreshed for user: {user.UserName}");

                return Ok(tokenResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error refreshing token: {ex.Message}");
                return StatusCode(500, new { message = "An error occurred refreshing the token", error = ex.Message });
            }
        }
    }
}
