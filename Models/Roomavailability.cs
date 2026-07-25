using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Roomavailability
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int RoomId { get; set; }

    public int TotalUnit { get; set; }
}
