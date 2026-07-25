using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string ClientName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CompanyId { get; set; }

    public Guid? UniqueId { get; set; }
}
