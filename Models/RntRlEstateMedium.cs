using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntRlEstateMedium
{
    public int Id { get; set; }

    public int? PidEstate { get; set; }

    public int? Sequence { get; set; }

    public string? Type { get; set; }

    public string? Code { get; set; }

    public string? ImgThumb { get; set; }

    public string? ImgBanner { get; set; }

    public string? VideoPath { get; set; }

    public string? VideoEmbed { get; set; }

    public string? ImageTitle { get; set; }

    public int? PidRoomorama { get; set; }

    public int? PidCode { get; set; }
}
