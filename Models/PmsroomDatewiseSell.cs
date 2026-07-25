using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class PmsroomDatewiseSell
{
    public int Id { get; set; }

    public int RoomId { get; set; }

    public DateTime SellDate { get; set; }

    public int Sell { get; set; }
}
