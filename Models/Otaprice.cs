using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Otaprice
{
    public int Id { get; set; }

    public Guid UniqueId { get; set; }

    public int RoomTypeId { get; set; }

    public bool? IsAutomatic { get; set; }
}
