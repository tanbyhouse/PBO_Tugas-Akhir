using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrack.Models_s
{
    public class KeranjangItem
    {
        public Browny Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Product.HargaBrownies * Quantity;
    }
}
