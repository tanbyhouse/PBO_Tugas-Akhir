using System;
using System.Collections.Generic;

namespace OrderTrack.Models_s;

public partial class VarianBrowny
{
    public int IdVarian { get; set; }

    public string NamaVarian { get; set; } = null!;

    public string? DeskripsiVarian { get; set; }

    public virtual ICollection<Browny> Brownies { get; set; } = new List<Browny>();
}
