using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class CustomResource : Attribute, IResourceFilter
{ 
    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        throw new NotImplementedException();
    }

    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        var apiKey = context.HttpContext.Request.Headers["ApiKey"];

        if (string.IsNullOrEmpty(apiKey))
        {
            context.Result = new UnauthorizedResult();
        }
    }
}