namespace WebApplication4.Models
{
    /// <summary>
    /// JWT Token Response Model - Returns the generated JWT token
    /// </summary>
    public class JwtTokenResponse
    {
        /// <summary>
        /// The JWT access token
        /// </summary>
        public string? Token { get; set; }

        /// <summary>
        /// Token expiration time in seconds
        /// </summary>
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Token type (typically "Bearer")
        /// </summary>
        public string? TokenType { get; set; } = "Bearer";

        /// <summary>
        /// User information associated with the token
        /// </summary>
        public JwtUserInfo? User { get; set; }
    }

    /// <summary>
    /// User information included in JWT token response
    /// </summary>
    public class JwtUserInfo
    {
        /// <summary>
        /// User unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User username
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// User email address
        /// </summary>
        public string? Email { get; set; }
    }
}
