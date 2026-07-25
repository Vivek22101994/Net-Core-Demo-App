using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class ChangeRecovery
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime ExpiredTime { get; set; }

    public string UniqueId { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
