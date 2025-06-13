using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrackOwner.utils
{
    public class NavigationEventArgs : EventArgs
    {
        public UserControl userControl { get; }
        //public bool RequireSideBar { get; }
        //public bool RequireDetail { get; }
        //public bool IsOverLay { get; }
        public NavigationEventArgs(UserControl userControl)
        {
            this.userControl = userControl;
            //RequireSideBar = requireSideBar;
            //RequireDetail = requireDetail;
            //IsOverLay = isOverLay;
        }
    }
}