using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class BcomReservationMessage
{
    public int Id { get; set; }

    public string BookingReservationid { get; set; } = null!;

    public int Totalmessage { get; set; }
}
