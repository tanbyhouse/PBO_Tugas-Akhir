using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrack.Models_s
{
    public enum StatusPelanggan
    {
        active,       // Asumsi nilai di DB: 'aktif'
        completed_order,    // Asumsi nilai di DB: 'nonaktif'
        archieved     // Asumsi nilai di DB: 'diblokir'
    }
}
//CREATE TYPE status_pelanggan_enum AS ENUM ('active', 'completed_order', 'archived');

