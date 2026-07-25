using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Otaerrorlog
{
    public int Id { get; set; }

    public string ListingId { get; set; } = null!;

    public string ReponseContent { get; set; } = null!;

    public DateTime CreationDate { get; set; }
}
