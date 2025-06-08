using System;
using System.Collections.Generic;

namespace OrderTrack.Models;

public partial class LaporanBulanan
{
    public int IdLaporanBulanan { get; set; }

    public int Bulan { get; set; }

    public int Tahun { get; set; }

    public int TotalPesananBulanIni { get; set; }

    public decimal TotalPenghasilanBulanIni { get; set; }
}
