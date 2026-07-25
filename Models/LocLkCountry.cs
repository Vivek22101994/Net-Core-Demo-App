using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class LocLkCountry
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? InnerNotes { get; set; }

    public int? IsActive { get; set; }

    public int? HasRegion { get; set; }

    public int? HasProvince { get; set; }

    public string? ImgFlag { get; set; }

    public string? ImgPreview { get; set; }

    public int? CountryCode { get; set; }

    public string? ImgBanner { get; set; }

    public string? CountryPrefix { get; set; }
}
