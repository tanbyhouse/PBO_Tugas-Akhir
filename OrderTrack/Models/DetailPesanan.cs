using System;
using System.Collections.Generic;

namespace OrderTrack.Models;

public partial class DetailPesanan
{
    public int IdDetailPesanan { get; set; }

    public int IdPesanan { get; set; }

    public int IdBrownies { get; set; }

    public int JumlahItem { get; set; }

    public decimal HargaSatuanSaatPesan { get; set; }

    public decimal TotalHargaItem { get; set; }

    public virtual Brownies IdBrowniesNavigation { get; set; } = null!;

    public virtual Pesanan IdPesananNavigation { get; set; } = null!;
}
