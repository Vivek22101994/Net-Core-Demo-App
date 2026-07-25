using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class MappingActivityLog
{
    public int Id { get; set; }

    public int RoomTypeId { get; set; }

    public string? BeforeMapping { get; set; }

    public string? AfterMapping { get; set; }

    public string MapType { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string ModifyIp { get; set; } = null!;
}
