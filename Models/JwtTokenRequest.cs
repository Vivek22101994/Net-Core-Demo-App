namespace WebApplication4.Models
{
    /// <summary>
    /// JWT Token Request Model - Used for login credentials
    /// </summary>
    public class JwtTokenRequest
    {
        /// <summary>
        /// User username or email for authentication
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// User password for authentication
        /// </summary>
        public string? Password { get; set; }
    }
}
