using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntChnlExpediaHotelTbl
{
    public int HotelId { get; set; }

    public string? Name { get; set; }

    public string? City { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IsDemo { get; set; }

    public int IsActive { get; set; }

    public int? PidEstate { get; set; }

    public string? Status { get; set; }

    public string? Message { get; set; }
}
