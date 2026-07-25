using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AmentiesMetaDetail
{
    public int Id { get; set; }

    public string? MetaEnum { get; set; }

    public string? MetaEnumDescription { get; set; }

    public int AmentiesMetaId { get; set; }
}
