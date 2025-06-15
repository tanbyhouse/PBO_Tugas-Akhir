using System;

namespace OrderTrack.utils
{
    // EventArgs kustom untuk meneruskan data ringkasan keranjang
    // Meskipun MainView tidak akan menggunakannya, mungkin masih digunakan secara internal
    // atau untuk tujuan lain di masa depan. Kita tetap deklarasikan.
    public class CartSummaryUpdateEventArgs : EventArgs
    {
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Shipping { get; set; }
        public decimal Total { get; set; }

        public CartSummaryUpdateEventArgs(decimal subtotal, decimal tax, decimal shipping, decimal total)
        {
            Subtotal = subtotal;
            Tax = tax;
            Shipping = shipping;
            Total = total;
        }
    }
}
