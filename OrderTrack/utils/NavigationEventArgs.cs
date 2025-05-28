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
        public NavigationEventArgs(UserControl userControl, bool requireSideBar = false, bool requireDetail = false)
        {
            this.userControl = userControl;
            RequireSideBar = requireSideBar;
            RequireDetail = requireDetail;
        }
    }
}
