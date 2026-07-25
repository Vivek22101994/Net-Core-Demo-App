using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntEstatePriceV4tbl
{
    public int Id { get; set; }

    public int PidEstate { get; set; }

    public decimal PriceForExtraPerson { get; set; }
}
