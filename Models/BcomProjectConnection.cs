using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class BcomProjectConnection
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public int IsActive { get; set; }
}
