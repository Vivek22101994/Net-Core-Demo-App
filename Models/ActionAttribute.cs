using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics.CodeAnalysis;

public class ActionAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("Action Started");
    }
    public override void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("Action Executed");
    }
}