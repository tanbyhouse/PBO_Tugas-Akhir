// menyesuaikan assembly dari path folder nya yakni OrderTrack/utils
namespace OrderTrack.utils
{
    // merupakan class yang menginheritance UserControl dan INavigableUserControl dengan tujuan
    public partial class BaseUserControl : UserControl, INavigableUserControl
    {
        // atribut dari INavigableUserControl yang harus diimplementasikan
        public event EventHandler<NavigationEventArgs> NavigateToUserControlRequested;
        // method untuk menjalankan kode apa yang ingin di eksekusi
        // dalam hal ini isi NavigationEventArgs apa yang ingin di input
        protected virtual void OnNavigateToUserControlRequested(NavigationEventArgs e)
        {
            // karena sebelumnya MainNavigateToUserControlRequested sudah pernah berlangganan (+=)
            // dengan class yang didalamnya ada NavigateToUserControlRequested juga maka 
            // MainNavigateToUserControlRequested juga akan mendengarkan event yang terjadi
            NavigateToUserControlRequested?.Invoke(this, e);
        }
    }
}
