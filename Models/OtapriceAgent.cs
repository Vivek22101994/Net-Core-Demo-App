using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class OtapriceAgent
{
    public int Id { get; set; }

    public int OtapriceId { get; set; }

    public int Otacode { get; set; }

    public decimal Price { get; set; }

    public DateTime? DtCreation { get; set; }
}
