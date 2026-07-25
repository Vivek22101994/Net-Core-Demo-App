using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AuthClientTbl
{
    public long Id { get; set; }

    public Guid Uid { get; set; }

    public string? Code { get; set; }

    public string? TypeCode { get; set; }

    public string? PidLang { get; set; }

    public string? AuthUsr { get; set; }

    public string? AuthPwd { get; set; }

    public string? NameHonorific { get; set; }

    public string? NameFull { get; set; }

    public string? NameFirst { get; set; }

    public string? NameMiddle { get; set; }

    public string? NameLast { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactPhoneTrip { get; set; }

    public string? ContactPhoneMobile { get; set; }

    public string? ContactPhoneOffice { get; set; }

    public string? ContactFax { get; set; }

    public string? DocType { get; set; }

    public string? DocNum { get; set; }

    public string? DocIssuePlace { get; set; }

    public DateTime? DocIssueDate { get; set; }

    public DateTime? DocExpiryDate { get; set; }

    public string? DocVat { get; set; }

    public string? DocCf { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? BirthPlace { get; set; }

    public string? BirthCountry { get; set; }

    public string? BirthState { get; set; }

    public string? LocCountry { get; set; }

    public string? LocState { get; set; }

    public string? LocCity { get; set; }

    public string? LocAddress { get; set; }

    public string? LocZipCode { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedUserId { get; set; }

    public string? CreatedUserNameFull { get; set; }

    public string? NotesInner { get; set; }

    public string? NotesInvoice { get; set; }

    public long? PidAgent { get; set; }

    public int? PidRoomoramaClient { get; set; }

    public string? BirthProvince { get; set; }

    public string? BirthCity { get; set; }

    public string? Citizenship { get; set; }

    public string? Gender { get; set; }

    public string? DocTypeIt { get; set; }

    public string? DocIssuePlaceIt { get; set; }

    public string? GuestType { get; set; }
}
