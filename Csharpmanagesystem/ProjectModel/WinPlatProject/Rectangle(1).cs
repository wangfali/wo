using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPlatProject
{
   
    public class Rectangle:IComputeArea,IComputeCube
    {
        #region 成员属性
        public double length { get; set; }
        public double height { get; set; }
        public double width { get; set; }
        #endregion

        #region 方法
        public double area()
        {          
            return length * width;
            
        }

        public double cube()
        {
            return length * width * height;
        }
        #endregion
    }
}
