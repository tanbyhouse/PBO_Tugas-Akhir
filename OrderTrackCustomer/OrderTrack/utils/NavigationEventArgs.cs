using System;
using System.Windows.Forms; // Penting untuk kelas UserControl

namespace OrderTrack.utils
{
    // EventArgs kustom untuk meneruskan informasi navigasi antar UserControl
    // Kita akan tetap menggunakan RequireSideBar dan RequireDetail,
    // tetapi MainView tidak akan lagi menggunakan RequireDetail untuk mengatur visibilitas pnlSummaryKeranjang-nya.
    // Ini mungkin masih berguna untuk logika navigasi lain jika ada sidebar navigasi kiri utama.
    public class NavigationEventArgs : EventArgs
    {
        public UserControl userControl { get; }
        public bool RequireSideBar { get; }
        public bool RequireDetail { get; }
        public bool IsOverlay { get; }

        public NavigationEventArgs(UserControl userControl, bool requireSideBar, bool requireDetail, bool isOverlay = false)
        {
            this.userControl = userControl;
            this.RequireSideBar = requireSideBar;
            this.RequireDetail = requireDetail;
            this.IsOverlay = isOverlay;
        }
    }
}
