using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntChnlHomeAwayAcceptedPaymentFormTbl
{
    public string PaymentFormType { get; set; } = null!;

    public string CardCode { get; set; } = null!;

    public string CardType { get; set; } = null!;

    public int? IsActive { get; set; }
}
