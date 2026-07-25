using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntEstateExtrasLn
{
    public int PidEstateExtras { get; set; }

    public string PidLang { get; set; } = null!;

    public string? Title { get; set; }

    public string? SubTitle { get; set; }

    public string? Description { get; set; }

    public string? Sommario { get; set; }

    public string? PagePath { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaDescription { get; set; }

    public int IdNew { get; set; }
}
