using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Pmsrequest
{
    public int Id { get; set; }

    public int RoomTypeId { get; set; }

    public string RequestPayload { get; set; } = null!;

    public DateTime CreationDate { get; set; }
}
