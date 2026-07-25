using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Pmsotamapping
{
    public int Id { get; set; }

    public int MrId { get; set; }

    public string BcmRoomId { get; set; } = null!;
}
