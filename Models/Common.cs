using Microsoft.Extensions.Options;

public class Common
{
    private  readonly IOptionsMonitor<EmailOptions> _options;

    public Common(IOptionsMonitor<EmailOptions> options)
    {
        _options = options;
    }

    public int GetSMTPPort()
    {
        return _options.CurrentValue.SmtpPort;
    }
}
