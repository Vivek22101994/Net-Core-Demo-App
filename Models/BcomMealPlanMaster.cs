using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class BcomMealPlanMaster
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string Title { get; set; } = null!;
}
