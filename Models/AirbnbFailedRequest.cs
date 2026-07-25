using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AirbnbFailedRequest
{
    public int Id { get; set; }

    public string RequestUrl { get; set; } = null!;

    public string RequestContent { get; set; } = null!;

    public string HostId { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
