using System;
using System.Collections.Generic;

namespace OrderTrack.Models;

public partial class LaporanTahunan
{
    public int IdLaporanTahunan { get; set; }

    public int Tahun { get; set; }

    public int TotalPesananTahunIni { get; set; }

    public decimal TotalPenghasilanTahunIni { get; set; }
}
