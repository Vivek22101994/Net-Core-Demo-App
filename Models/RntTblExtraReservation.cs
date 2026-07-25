using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntTblExtraReservation
{
    public long PidReservation { get; set; }

    public int PidExtra { get; set; }

    public decimal? Price { get; set; }

    public int? IsIncluded { get; set; }

    public int? IsPerNight { get; set; }

    public int? IsPerPerson { get; set; }
}
