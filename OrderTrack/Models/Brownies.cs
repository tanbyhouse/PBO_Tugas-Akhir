using System; 
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static Guna.UI2.Native.WinApi;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Configuration.Json;

namespace OrderTrack.Models
{
    public partial class Brownies
    {
        [Key]
        public int id_brownies { get; set; }
        public int id_varian { get; set; }
        public string nama_brownies { get; set; }
        [Column (TypeName = "decimal(10, 2)")]
        public decimal kuantitas_brownies { get; set; }
        public string satuan_kuantitas { get; set; } 
        public decimal harga_brownies { get; set; }
        public string deskripsi { get; set; }
        [ForeignKey("id_varian")]
        public VarianBrownies varian_brownies { get; set; }
        public ICollection<DetailPesanan> DetailPesanan { get; set; }
    }
}

//CREATE TABLE brownies (
//    id_brownies SERIAL PRIMARY KEY,
//    id_varian INTEGER NOT NULL, -- Foreign Key ke varian_brownies
//    nama_brownies VARCHAR(25) NOT NULL,
//    kuantitas_brownies DECIMAL(10, 2) NOT NULL DEFAULT 0, -- DECIMAL untuk stok (misal: 500.00 gram)
//    satuan_kuantitas VARCHAR(25) NOT NULL, -- Contoh: 'gram', 'unit', 'box'
//    harga_brownies DECIMAL(10, 2) NOT NULL, -- Harga per satuan kuantitas (misal: harga per gram atau per unit)
//    deskripsi TEXT, -- Deskripsi produk
//    CONSTRAINT fk_brownies_id_varian
//        FOREIGN KEY (id_varian)
//        REFERENCES varian_brownies (id_varian)
//        ON DELETE RESTRICT -- Tidak bisa menghapus varian jika masih ada brownies yang menggunakannya
//        ON UPDATE CASCADE -- Jika ID varian berubah, update di sini juga
//);