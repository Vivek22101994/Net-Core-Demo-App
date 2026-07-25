using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class PmsotarateplanMapping
{
    public int Id { get; set; }

    public int PmsratepmanId { get; set; }

    public string OtarateplanId { get; set; } = null!;

    public int? ProjectId { get; set; }
}
