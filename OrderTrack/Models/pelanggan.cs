using System;
using System.Collections.Generic;

namespace OrderTrack.Models;

public partial class Pelanggan
{
    public int IdPelanggan { get; set; }

    public string NamaPelanggan { get; set; } = null!;

    public string AlamatPelanggan { get; set; } = null!;

    public string NomorHp { get; set; } = null!;
    public StatusPelanggan StatusPelanggan { get; set; }

    public virtual ICollection<Pesanan> Pesanans { get; set; } = new List<Pesanan>();
}
