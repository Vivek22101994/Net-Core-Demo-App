using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models;

public partial class UsrAdmin
{
    [Key]
    public int UserId { get; set; }

    public Guid UniqueId { get; set; }

    public string UserName { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? ProjectId { get; set; }

    public string? Email { get; set; }

    public string? Lang { get; set; }
}
