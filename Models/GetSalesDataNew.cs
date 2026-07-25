using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class GetSalesDataNew
{
    public DateTime DtStart { get; set; }

    public DateTime DtEnd { get; set; }

    public decimal PriceAmount { get; set; }

    public int PidEstate { get; set; }

    public string? Code { get; set; }
}
