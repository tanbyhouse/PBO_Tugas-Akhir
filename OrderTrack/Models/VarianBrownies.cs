using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Configuration.Json;

namespace OrderTrack.Models
{
    public partial class VarianBrownies
    {
        [Key]
        public int id_varian { get; set; }
        public string nama_varian { get; set; }
        public string deskripsi_varian { get; set; }
    }
}

//CREATE TABLE varian_brownies (
//    id_varian SERIAL PRIMARY KEY, -- SERIAL untuk auto-incrementing integer PK
//    nama_varian VARCHAR(100) NOT NULL UNIQUE, -- Nama varian harus unik
//    deskripsi_varian TEXT -- TEXT untuk deskripsi yang mungkin panjang
//);