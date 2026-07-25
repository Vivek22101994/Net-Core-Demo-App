using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class BcomDayPrice
{
    public int Id { get; set; }

    public DateTime PriceDate { get; set; }

    public decimal Price { get; set; }

    public long? ReservationId { get; set; }
}
