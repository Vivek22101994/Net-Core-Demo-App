using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntBcomHotelTbl
{
    public int Id { get; set; }

    public string? HotelId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? RateIdStandard { get; set; }

    public string? RateIdNotRefund { get; set; }

    public string? RateIdSpecial { get; set; }

    public string? RateIdGenius { get; set; }

    public string? Title { get; set; }

    public int? IsActive { get; set; }

    public string? HotelName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int? PhoneTechType { get; set; }

    public string? Extension { get; set; }

    public string? CompanyCode { get; set; }

    public string? GoogleMaps { get; set; }

    public string? LocPhysicalAddress { get; set; }

    public int? PidPhysicalCity { get; set; }

    public string? LocPhysicalCountry { get; set; }

    public string? LocPhysicalZipCode { get; set; }

    public string? InvoiceName { get; set; }

    public string? InvoiceSurName { get; set; }

    public string? LocInvoiceAddress { get; set; }

    public int? LocInvoiceCity { get; set; }

    public string? LocInvoiceState { get; set; }

    public string? LocInvoiceZipCode { get; set; }

    public string? LocInvoiceCountry { get; set; }

    public int? CancellationPolicyCode { get; set; }

    public int? PidEstateId { get; set; }

    public string? GeneralName { get; set; }

    public string? GeneralSurName { get; set; }

    public string? InvoicePhone { get; set; }

    public int? InvoicePhoneTechType { get; set; }

    public string? InvoiceExtension { get; set; }

    public string? DefCheckIn { get; set; }

    public string? DefCheckOut { get; set; }

    public int? UsualStayFreeCutoffAge { get; set; }

    public int? UsualStayFreeChildPerAdult { get; set; }

    public string? PetsAllowedCode { get; set; }

    public string? PetPolicyNonRefundableFee { get; set; }

    public int? GuestRoomInfoQuantity { get; set; }

    public int? HotelCategoryExistsCode { get; set; }

    public int? HotelCategoryCode { get; set; }

    public bool? IsContentApiHotel { get; set; }

    public string? StandardRateName { get; set; }

    public string? NotRefundRateName { get; set; }

    public string? SpecialRateName { get; set; }

    public string? GeniusRateName { get; set; }

    public bool? IsStandardRateActive { get; set; }

    public bool? IsNotRefundRateActive { get; set; }

    public bool? IsSpecialRateActive { get; set; }

    public bool? IsGeniusRateActive { get; set; }

    public int? TotalNumberOfFloors { get; set; }

    public string? StaffLanguages { get; set; }

    public string? HotelierMessage { get; set; }

    public string? HotelierMessageLanguage { get; set; }

    public string? Ruid { get; set; }

    public string? ClientId { get; set; }

    public string? ClientSecret { get; set; }
}
