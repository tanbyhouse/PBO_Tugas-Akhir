// menyesuaikan assembly dari path folder nya yakni OrderTrack/utils
namespace OrderTrack.utils
{
    // EventArgs kustom untuk meneruskan informasi navigasi antar UserControl
    public class NavigationEventArgs : EventArgs
    {
        public UserControl userControl { get; } // penerapan enkapsulasi sebagai konsep OOP
        public bool RequireSideBar { get; } // penerapan enkapsulasi sebagai konsep OOP
        
        // constructors yang digunakan saat objek dibuat dari class ini
        public NavigationEventArgs(UserControl userControl, bool requireSideBar)
        {
            this.userControl = userControl;
            this.RequireSideBar = requireSideBar;
        }
    }
}
