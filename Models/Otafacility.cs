using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Otafacility
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Otaid { get; set; } = null!;

    public string Ota { get; set; } = null!;

    public Guid? UniqueId { get; set; }

    public int CompanyId { get; set; }
}
