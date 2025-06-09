using System;
using System.Collections.Generic;

namespace OrderTrack.Models_s;

public partial class LaporanHarian
{
    public int IdLaporanHarian { get; set; }

    public DateOnly Tanggal { get; set; }

    public int TotalPesananSelesai { get; set; }

    public decimal TotalPenghasilanBersih { get; set; }
}
