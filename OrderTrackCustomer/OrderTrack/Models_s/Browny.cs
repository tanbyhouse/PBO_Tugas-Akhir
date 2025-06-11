using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderTrack.Models_s;

public partial class Browny
{
    public int IdBrownies { get; set; }

    public int IdVarian { get; set; }

    public string NamaBrownies { get; set; } = null!;

    public decimal KuantitasBrownies { get; set; }

    public string SatuanKuantitas { get; set; } = null!;

    public decimal HargaBrownies { get; set; }

    public string? Deskripsi { get; set; }
    
    [Column("gambar_path")]
    public string? GambarPath { get; set; }

    public virtual ICollection<DetailPesanan> DetailPesanans { get; set; } = new List<DetailPesanan>();

    public virtual VarianBrowny IdVarianNavigation { get; set; } = null!;
}
