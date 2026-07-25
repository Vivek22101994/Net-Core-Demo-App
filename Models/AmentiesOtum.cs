using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AmentiesOtum
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? EnumCode { get; set; }

    public string? MetaCode { get; set; }

    public Guid Uid { get; set; }

    public string? MetaDescription { get; set; }

    public string? Ota { get; set; }
}
