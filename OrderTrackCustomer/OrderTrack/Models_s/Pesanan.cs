using System;
using System.Collections.Generic;

namespace OrderTrack.Models_s;

public partial class Pesanan
{
    public int IdPesanan { get; set; }

    public int IdPelanggan { get; set; }

    public DateOnly TanggalPesanan { get; set; }

    public virtual ICollection<DetailPesanan> DetailPesanans { get; set; } = new List<DetailPesanan>();
    public string StatusPesanan { get; set; }

    public virtual Pelanggan IdPelangganNavigation { get; set; } = null!;
}
