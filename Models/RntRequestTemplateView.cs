using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntRequestTemplateView
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? InnerNotes { get; set; }

    public string? ReplaceNotes { get; set; }

    public int? PidUser { get; set; }

    public string? Body { get; set; }

    public string? Subject { get; set; }

    public string PidLang { get; set; } = null!;

    public int? IsAutomatic { get; set; }

    public int? IsBefore { get; set; }

    public string? TimeType { get; set; }

    public int? NumTime { get; set; }

    public string? Filename { get; set; }

    public int? IsForRequest { get; set; }

    public int? IsForReservation { get; set; }

    public int? PidEvent { get; set; }

    public int? PidRecipient { get; set; }

    public int? IsActive { get; set; }
}
