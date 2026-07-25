using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class ProjectType
{
    public int Id { get; set; }

    public string ProjectTypeTitle { get; set; } = null!;

    public Guid? UniqueId { get; set; }
}
