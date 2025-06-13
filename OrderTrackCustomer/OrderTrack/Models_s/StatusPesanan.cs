using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrack.Models_s
{
    public enum StatusPesanan
    {
        pending,     // Asumsi nilai di DB: 'pending'
        diproses,    // Asumsi nilai di DB: 'diproses'
        diterima,     // Asumsi nilai di DB: 'selesai'
        ditolak   // Asumsi nilai di DB: 'dibatalkan'
    }
}
//CREATE TYPE status_pesanan_enum AS ENUM ('pending', 'diproses', 'dikirim', 'diterima', 'dibatalkan', 'ditolak');

