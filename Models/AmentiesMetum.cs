using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AmentiesMetum
{
    public int Id { get; set; }

    public int AmentiesId { get; set; }

    public string Meta { get; set; } = null!;
}
