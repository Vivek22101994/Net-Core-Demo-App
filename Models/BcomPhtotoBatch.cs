using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class BcomPhtotoBatch
{
    public int Id { get; set; }

    public string ParentId { get; set; } = null!;

    public string PatentType { get; set; } = null!;

    public string PhotoBatchId { get; set; } = null!;

    public string? ResponstPayload { get; set; }

    public bool? IsCompleted { get; set; }

    public string? RoomTypeId { get; set; }
}
