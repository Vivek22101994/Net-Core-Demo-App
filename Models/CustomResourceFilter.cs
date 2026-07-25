using Microsoft.AspNetCore.Mvc.Filters;

public class CustomResourceFilter : Attribute, IResourceFilter
{
    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        Console.WriteLine("Before Resource Execution");
    }

    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        Console.WriteLine("After Resource Execution");
    }
}