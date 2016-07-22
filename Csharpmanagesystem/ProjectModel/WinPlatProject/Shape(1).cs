using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPlatProject
{
    public delegate double AreaHandle(Shape p);
    public class Shape
    {
        public event AreaHandle AreaEvent=null;//定义事件

        public double CallAreaEvent()
        {
            if (AreaEvent == null)
                return 0;
            else
                return AreaEvent(this);
        }
    }
}
