using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AgodaHotelRateplan
{
    public int Id { get; set; }

    public string AgodaId { get; set; } = null!;

    public string RatePlanId { get; set; } = null!;

    public string RatePlan { get; set; } = null!;

    public int RatePlanType { get; set; }

    public bool IsActive { get; set; }

    public string? ParentRatePlan { get; set; }

    public int? PerVal { get; set; }

    public int? MasterRate { get; set; }

    public DateTime? SellStart { get; set; }

    public DateTime? SellEnd { get; set; }

    public DateTime? StayStart { get; set; }

    public DateTime? StayEnd { get; set; }

    public bool? TaxIncluded { get; set; }

    public string? RateType { get; set; }

    public int? MinAdvDays { get; set; }

    public int? MaxAdvDays { get; set; }

    public int? MinStay { get; set; }

    public int? MaxStay { get; set; }

    public string? CancelationCode { get; set; }

    public int? OfferTypeId { get; set; }

    public string? OfferTypeName { get; set; }

    public string? BenifitId { get; set; }

    public string? BenifitName { get; set; }
}
