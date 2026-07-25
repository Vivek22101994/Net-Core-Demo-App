using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntEstatePriceV4datesTbl
{
    public int PidEstate { get; set; }

    public long PidSeasonDate { get; set; }

    public decimal PriceOwner { get; set; }

    public decimal PriceAmount { get; set; }

    public decimal PrMargine { get; set; }

    public bool InDay1 { get; set; }

    public bool InDay2 { get; set; }

    public bool InDay3 { get; set; }

    public bool InDay4 { get; set; }

    public bool InDay5 { get; set; }

    public bool InDay6 { get; set; }

    public bool InDay7 { get; set; }

    public bool OutDay1 { get; set; }

    public bool OutDay2 { get; set; }

    public bool OutDay3 { get; set; }

    public bool OutDay4 { get; set; }

    public bool OutDay5 { get; set; }

    public bool OutDay6 { get; set; }

    public bool OutDay7 { get; set; }

    public string PromoList { get; set; } = null!;

    public int NightsMin { get; set; }

    public int NightsMax { get; set; }

    public decimal? PrMargineVat { get; set; }
}
