using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class GoogleUser
{
    public int GoogleUserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int CompanyId { get; set; }

    public DateTime CreatedDate { get; set; }
}
