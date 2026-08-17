namespace WebApplication4.Models
{
    public class OllmaChat
    {
        public string message { get; set; }
        public string response { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public IFormFile? image { get; set; }
    }
}
