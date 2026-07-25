using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntEstatePriceV4datesTblchannel
{
    public int PidEstate { get; set; }

    public DateTime DtStart { get; set; }

    public DateTime DtEnd { get; set; }

    public decimal PriceOwner { get; set; }

    public decimal PriceAmount { get; set; }

    public decimal PrMargine { get; set; }

    public int NightsMin { get; set; }

    public int NightsMax { get; set; }

    public decimal? PrMargineVat { get; set; }

    public int ChannelId { get; set; }

    public int Id { get; set; }

    public string? RatePlanId { get; set; }

    public int? IsClosed { get; set; }
}
