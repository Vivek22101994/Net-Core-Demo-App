using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntChnlExpediaEstateTbl
{
    public int Id { get; set; }

    public int HotelId { get; set; }

    public string RoomTypeId { get; set; } = null!;
}
