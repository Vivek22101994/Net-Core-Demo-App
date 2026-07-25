using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntExtrasCategoryTb
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? ImgThumb { get; set; }

    public string? ImgPreview { get; set; }

    public int IsActive { get; set; }
}
