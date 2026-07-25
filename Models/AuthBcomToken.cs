using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AuthBcomToken
{
    public int Id { get; set; }

    public string ClientId { get; set; } = null!;

    public string ClientSecret { get; set; } = null!;

    public string? Token { get; set; }

    public DateTime? LastRefreshDateTime { get; set; }
}
