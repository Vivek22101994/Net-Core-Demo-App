using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntAgentTbl
{
    public long Id { get; set; }

    public Guid? Uid { get; set; }

    public string? Code { get; set; }

    public string? PidLang { get; set; }

    public int? PidReferer { get; set; }

    public int? HasAcceptedContract { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeTitle { get; set; }

    public decimal? DeleteFromHere { get; set; }

    public decimal? CashDiscount { get; set; }

    public int? PidDiscountType { get; set; }

    public int? PayDiscountNotPayed { get; set; }

    public int? PayFullPayment { get; set; }

    public int? PayToConfirm { get; set; }

    public decimal? DeleteToHere { get; set; }

    public string? NameCompany { get; set; }

    public string? NameHonor { get; set; }

    public string? NameFull { get; set; }

    public string? NameFirst { get; set; }

    public string? NameLast { get; set; }

    public string? DocType { get; set; }

    public string? DocNum { get; set; }

    public string? DocIssuePlace { get; set; }

    public DateTime? DocIssueDate { get; set; }

    public DateTime? DocExpiryDate { get; set; }

    public string? DocVat { get; set; }

    public int? DocVatIsEuReg { get; set; }

    public string? DocCf { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? BirthPlace { get; set; }

    public string? LocCountry { get; set; }

    public string? LocState { get; set; }

    public string? LocCity { get; set; }

    public string? LocAddress { get; set; }

    public string? LocZipCode { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactEmailInvoice { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactPhoneMobile { get; set; }

    public string? ContactFax { get; set; }

    public string? ContactWebSite { get; set; }

    public string? ContactComeFrom { get; set; }

    public string? AuthUsr { get; set; }

    public string? AuthPwd { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedUserId { get; set; }

    public string? CreatedUserNameFull { get; set; }

    public string? NotesClient { get; set; }

    public string? NotesInner { get; set; }

    public string? NotesInvoice { get; set; }

    public decimal? CashTaxFree { get; set; }

    public decimal? CashTaxAmount { get; set; }

    public decimal? CashTotalAmount { get; set; }

    public decimal? CashPayed { get; set; }

    public DateTime? CashPayedDateTime { get; set; }

    public string? CashPayedTxnId { get; set; }

    public int? Fattura { get; set; }

    public int? Voucher { get; set; }

    public int? IsPaymentBefore { get; set; }

    public int? Days { get; set; }

    public int? IsAllPayment { get; set; }

    public decimal? PartPayment { get; set; }

    public decimal? Balance { get; set; }

    public int? IsCustomerPaysAgency { get; set; }

    public int? IsInvoiceComplete { get; set; }

    public decimal? InvoicePercentage { get; set; }

    public int? InvCompanyId { get; set; }

    public int? InvTaxId { get; set; }

    public int? IsIntegrate { get; set; }

    public int? IsMsgsEnabled { get; set; }

    public int? IsAgencyFeeApplied { get; set; }

    public string? IdAdMedia { get; set; }

    public string? ChnlEstatePage { get; set; }

    public int? ChnlMgetPhotos { get; set; }

    public int? ChnlMgetTexts { get; set; }

    public int? ChnlMgetAddress { get; set; }

    public int? ChnlMgetAmenities { get; set; }

    public string? ImgLogo { get; set; }

    public int? SupportMultiUnit { get; set; }

    public int? IsInternalWebsite { get; set; }

    public int? ChnlMgetPrices { get; set; }

    public int? IsSendNightWisePrice { get; set; }

    public string? ClLocProvince { get; set; }

    public string? HaadvertiserAssignedId { get; set; }
}
