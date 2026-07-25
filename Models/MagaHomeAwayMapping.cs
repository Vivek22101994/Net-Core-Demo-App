using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class MagaHomeAwayMapping
{
    public int Id { get; set; }

    public int MagaRoomId { get; set; }

    public int IsActive { get; set; }
}
