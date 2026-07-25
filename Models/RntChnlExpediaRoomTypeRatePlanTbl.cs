using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntChnlExpediaRoomTypeRatePlanTbl
{
    public string RoomTypeId { get; set; } = null!;

    public string RatePlanId { get; set; } = null!;

    public string? Code { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public string? Type { get; set; }

    public string? DistributionModel { get; set; }

    public string? RateAcquisitionType { get; set; }

    public string? ParentId { get; set; }

    public DateTime? RateLinkStart { get; set; }

    public DateTime? RateLinkEnd { get; set; }

    public bool? IsAvailStatusLinked { get; set; }

    public bool? AreMinMaxLoslinked { get; set; }

    public bool? IsCtalinked { get; set; }

    public bool? IsCtdlinked { get; set; }

    public bool? RateLinkExceptions { get; set; }

    public string? PricingModel { get; set; }

    public int? OccupantsForBaseRate { get; set; }

    public bool? DepositRequired { get; set; }

    public int? MinLosdefault { get; set; }

    public int? MaxLosdefault { get; set; }

    public int? MinAdvBookDays { get; set; }

    public int? MaxAdvBookDays { get; set; }

    public DateTime? BookDateStart { get; set; }

    public DateTime? BookDateEnd { get; set; }

    public DateTime? TravelDateStart { get; set; }

    public DateTime? TravelDateEnd { get; set; }

    public bool? MobileOnly { get; set; }

    public string? CreateDateTime { get; set; }

    public string? UpdateDateTime { get; set; }

    public int RateChangeAmount { get; set; }

    public int RateChangeIsDiscount { get; set; }

    public int RateChangeIsPercentage { get; set; }

    public string? ValueAddInclusions { get; set; }
}
