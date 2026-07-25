using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/Detail")]
        public IActionResult Detail()
        {
            var ExeceptionDetail = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.StackTrace = ExeceptionDetail.Error.StackTrace;
            ViewBag.PagePath = ExeceptionDetail.Path;
            ViewBag.ExecptionMessage = ExeceptionDetail.Error.Message;
            return View();
        }
        [Route("Error/Detail/{StatusCode}")]
        public IActionResult DetailSttaus(int StatusCode)
        {
            var StatsCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch(StatusCode)
            {
                case 404:
                    ViewBag.Message = "Resource Not Found";
                    ViewBag.Page = StatsCodeResult.OriginalPath;
                    ViewBag.QString = StatsCodeResult.OriginalQueryString;
                    break;
            }            
            return View();
        }
    }
}
