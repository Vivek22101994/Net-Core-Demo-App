using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Pmsavailability
{
    public long Id { get; set; }

    public int PidEstate { get; set; }

    public long PidSeasonDate { get; set; }

    public int? TotalRoom { get; set; }
}
