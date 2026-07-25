using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class OtadateWisePrice
{
    public int ID { get; set; }

    public int OtapriceId { get; set; }

    public int MaxSell { get; set; }

    public DateTime SellDate { get; set; }
}
