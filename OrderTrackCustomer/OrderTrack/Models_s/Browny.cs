using System.ComponentModel.DataAnnotations.Schema; // Penting untuk atribut [Column("gambar_path")]

namespace OrderTrack.Models_s; // Deklarasi namespace gaya file-scoped (C# 10+)

public partial class Browny
{
    public int IdBrownies { get; set; } // Properti untuk Primary Key

    public int IdVarian { get; set; } // Properti untuk Foreign Key ke VarianBrowny

    public string NamaBrownies { get; set; } = null!; // Properti untuk nama produk

    public decimal KuantitasBrownies { get; set; } // Properti untuk kuantitas stok

    public string SatuanKuantitas { get; set; } = null!; // Properti untuk satuan kuantitas (misal: "gram", "pcs")

    public decimal HargaBrownies { get; set; } // Properti untuk harga produk

    public string? Deskripsi { get; set; } // Properti untuk deskripsi (nullable)

    [Column("gambar_path")] // Atribut untuk memetakan nama kolom database yang berbeda
    public string? GambarPath { get; set; } // Properti untuk path gambar (nullable)

    // Properti Navigasi untuk relasi Many-to-Many atau One-to-Many
    public virtual ICollection<DetailPesanan> DetailPesanans { get; set; } = new List<DetailPesanan>();

    // Properti Navigasi untuk relasi One-to-One atau Many-to-One
    public virtual VarianBrowny IdVarianNavigation { get; set; } = null!;
}