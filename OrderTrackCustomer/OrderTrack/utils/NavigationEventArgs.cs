using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrack.utils
{
    public class NavigationEventArgs : EventArgs
    {
        public UserControl userControl { get; }
        public bool RequireSideBar { get; }
        public bool RequireDetail { get; }
        public bool IsOverLay { get; }
        public NavigationEventArgs(UserControl userControl, bool requireSideBar = false, bool requireDetail = false, bool isOverLay = false)
        {
            this.userControl = userControl;
            RequireSideBar = requireSideBar;
            RequireDetail = requireDetail;
            IsOverLay = isOverLay;
        }
    }
}
