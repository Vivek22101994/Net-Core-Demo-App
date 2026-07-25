using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class ContLangTbl
{
    public string Id { get; set; } = null!;

    public string? Title { get; set; }

    public string? LangTitle { get; set; }

    public string? CommonName { get; set; }

    public string? Abbr { get; set; }

    public string? JsCalFile { get; set; }

    public int? IsActive { get; set; }

    public int? IsPublic { get; set; }

    public string? ImgThumb { get; set; }

    public string? ImgPreview { get; set; }

    public int? PidCountry { get; set; }

    public int? Sequence { get; set; }
}
