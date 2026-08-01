public class EndpointConecction
{
    public async Task<IResult> Handle()
    {
        var response = new
        {
            message = "Handled by NotificationHandler class",
            status = "success",
            timestamp = DateTime.UtcNow
        }; 
        return Results.Ok(response);
    }
}