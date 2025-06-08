using System;
using System.Collections.Generic;

namespace OrderTrack.Models;

public partial class Pesanan
{
    public int IdPesanan { get; set; }

    public int IdPelanggan { get; set; }

    public DateOnly TanggalPesanan { get; set; }

    public StatusPesanan StatusPesanan { get; set; }

    public virtual ICollection<DetailPesanan> DetailPesanans { get; set; } = new List<DetailPesanan>();

    public virtual Pelanggan IdPelangganNavigation { get; set; } = null!;
}
