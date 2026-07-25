using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntEstateExtrasView
{
    public int Id { get; set; }

    public string? PriceType { get; set; }

    public decimal? PriceAmount { get; set; }

    public int? IsRequired { get; set; }

    public int? IsInstantPayment { get; set; }

    public int? IsInInvoice { get; set; }

    public int? HasPeriodLimits { get; set; }

    public string? ImgThumb { get; set; }

    public string? ImgPreview { get; set; }

    public int? InnerType { get; set; }

    public int? InnerCategory { get; set; }

    public string? InnerNotes { get; set; }

    public int? IsImportant { get; set; }

    public int? IsInFilters { get; set; }

    public int? IsInResArea { get; set; }

    public int? PidCity { get; set; }

    public int? PidCategory { get; set; }

    public int? PidSubCategory { get; set; }

    public int? IsForAllApartment { get; set; }

    public int? PidMacroCategory { get; set; }

    public int? PidOwner { get; set; }

    public string PidLang { get; set; } = null!;

    public string? Title { get; set; }

    public string? SubTitle { get; set; }

    public string? Description { get; set; }

    public string? Sommario { get; set; }

    public string? PagePath { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaDescription { get; set; }

    public int? Sequence { get; set; }

    public int? HasDistance { get; set; }

    public Guid? UniqueId { get; set; }

    public string? Category { get; set; }
}
