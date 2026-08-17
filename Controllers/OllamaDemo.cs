using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.AI;
using Microsoft.Identity.Client;
using System.Text;
using WebApplication4.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApplication4.Controllers
{
    public class OllamaDemo : Controller
    {
        private readonly IChatClient _chatClient;
        public OllamaDemo(IChatClient chatClient)
        {
            _chatClient = chatClient;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("StreamChat")]
        public async Task StreamChat([FromForm] string? message, [FromForm] IFormFile? image)
        {
            Response.ContentType = "text/plain; charset=utf-8";
            Response.Headers.Append("Cache-Control", "no-cache");

            try
            {
                var contents = new List<AIContent>();

                if (!string.IsNullOrWhiteSpace(message))
                    contents.Add(new TextContent(message));

                if (image != null && image.Length > 0)
                {
                    using var ms = new MemoryStream();
                    await image.CopyToAsync(ms);
                    var bytes = ms.ToArray();

                    contents.Add(new DataContent(bytes, image.ContentType));

                    if (string.IsNullOrWhiteSpace(message))
                        contents.Insert(0, new TextContent("Describe this image in detail."));
                }

                var chatMessage = new ChatMessage(ChatRole.User, contents);

                await foreach (var update in _chatClient.GetStreamingResponseAsync([chatMessage]))
                {
                    if (!string.IsNullOrEmpty(update.Text))
                    {
                        await Response.WriteAsync(update.Text);
                        await Response.Body.FlushAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                await Response.WriteAsync($"\n[Error: {ex.Message}]");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Index(OllmaChat ollmaChat)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var message = new ChatMessage(ChatRole.User, ollmaChat.message);           
            await foreach (var update in _chatClient.GetStreamingResponseAsync(message))
            {
                if (!string.IsNullOrEmpty(update.Text))
                {
                    stringBuilder.Append(update.Text);                   
                }
            }
            ollmaChat.response = stringBuilder.ToString();
            return View("Index", ollmaChat);
        }
    }
}
