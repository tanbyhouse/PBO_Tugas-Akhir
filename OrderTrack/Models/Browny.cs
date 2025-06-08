using System;
using System.Collections.Generic;

namespace OrderTrack.Models;

public partial class Brownies
{
    public int IdBrownies { get; set; }

    public int IdVarian { get; set; }

    public string NamaBrownies { get; set; } = null!;

    public decimal KuantitasBrownies { get; set; }

    public string SatuanKuantitas { get; set; } = null!;

    public decimal HargaBrownies { get; set; }

    public string? Deskripsi { get; set; }

    public virtual ICollection<DetailPesanan> DetailPesanans { get; set; } = new List<DetailPesanan>();

    public virtual VarianBrownies IdVarianNavigation { get; set; } = null!;
}
