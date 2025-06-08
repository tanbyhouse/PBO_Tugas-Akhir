using System;
using System.Collections.Generic;

namespace OrderTrack.Models;

public partial class VarianBrownies
{
    public int IdVarian { get; set; }

    public string NamaVarian { get; set; } = null!;

    public string? DeskripsiVarian { get; set; }

    public virtual ICollection<Brownies> Brownies { get; set; } = new List<Brownies>();
}
