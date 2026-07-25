using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class GetRoomProperty
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public int ComplexId { get; set; }

    public string? SignleRoomName { get; set; }
}
