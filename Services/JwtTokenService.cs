using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication4.Models;

namespace WebApplication4.Services
{
    /// <summary>
    /// Service for generating and validating JWT tokens
    /// </summary>
    public interface IJwtTokenService
    {
        /// <summary>
        /// Generate a JWT token for the authenticated user
        /// </summary>
        /// <param name="user">The user to generate token for</param>
        /// <returns>JWT token response containing the token and metadata</returns>
        JwtTokenResponse GenerateToken(UsrAdmin user);

        /// <summary>
        /// Validate and extract claims from a JWT token
        /// </summary>
        /// <param name="token">The JWT token to validate</param>
        /// <returns>ClaimsPrincipal if valid, null if invalid</returns>
        ClaimsPrincipal? ValidateToken(string token);
    }

    /// <summary>
    /// Implementation of JWT token service
    /// </summary>
    public class JwtTokenService : IJwtTokenService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<JwtTokenService> _logger;

        public JwtTokenService(IConfiguration configuration, ILogger<JwtTokenService> logger)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Generate a JWT token for the authenticated user
        /// </summary>
        public JwtTokenResponse GenerateToken(UsrAdmin user)
        {
            try
            {
                var jwtSettings = _configuration.GetSection("JwtSettings");
                var secretKey = jwtSettings["SecretKey"];
                var issuer = jwtSettings["Issuer"];
                var audience = jwtSettings["Audience"];
                var expiryMinutes = int.Parse(jwtSettings["ExpiryMinutes"] ?? "60");

                if (string.IsNullOrEmpty(secretKey))
                {
                    _logger.LogError("JWT SecretKey is not configured in appsettings.json");
                    throw new InvalidOperationException("JWT SecretKey is not configured");
                }

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                // Create claims for the token
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName ?? string.Empty),
                    new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                    new Claim("UniqueId", user.UniqueId.ToString()),
                    new Claim("RoleId", user.RoleId.ToString())
                };
                var token = new JwtSecurityToken(
                    issuer: issuer,
                    audience: audience,
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(expiryMinutes),
                    signingCredentials: credentials
                );
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenString = tokenHandler.WriteToken(token);

                _logger.LogInformation($"JWT token generated successfully for user: {user.UserName}");

                return new JwtTokenResponse
                {
                    Token = tokenString,
                    ExpiresIn = expiryMinutes * 60, // Convert to seconds
                    TokenType = "Bearer",
                    User = new JwtUserInfo
                    {
                        Id = user.UserId,
                        Username = user.UserName,
                        Email = user.Email
                    }
                };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error generating JWT token: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Validate and extract claims from a JWT token
        /// </summary>
        public ClaimsPrincipal? ValidateToken(string token)
        {
            try
            {
                var jwtSettings = _configuration.GetSection("JwtSettings");
                var secretKey = jwtSettings["SecretKey"];
                var issuer = jwtSettings["Issuer"];
                var audience = jwtSettings["Audience"];

                if (string.IsNullOrEmpty(secretKey))
                {
                    _logger.LogError("JWT SecretKey is not configured");
                    return null;
                }

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

                var tokenHandler = new JwtSecurityTokenHandler();

                var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = key,
                    ValidateIssuer = !string.IsNullOrEmpty(issuer),
                    ValidIssuer = issuer,
                    ValidateAudience = !string.IsNullOrEmpty(audience),
                    ValidAudience = audience,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                return principal;
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Token validation failed: {ex.Message}");
                return null;
            }
        }
    }
}
