using System;
using System.Collections.Generic;

namespace OrderTrackOwner.Data.Context_s;

public partial class DetailPesanan
{
    public int IdDetailPesanan { get; set; }

    public int IdPesanan { get; set; }

    public int IdBrownies { get; set; }

    public int JumlahItem { get; set; }

    public decimal HargaSatuanSaatPesan { get; set; }

    public decimal TotalHargaItem { get; set; }

    public virtual Browny IdBrowniesNavigation { get; set; } = null!;

    public virtual Pesanan IdPesananNavigation { get; set; } = null!;
}
