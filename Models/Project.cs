using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public string ProjectName { get; set; } = null!;

    public int ClientId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? ProjectTypeId { get; set; }

    public int? IsAutoRoomAssigned { get; set; }

    public Guid? UniqueId { get; set; }
}
