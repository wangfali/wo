using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    /// <summary>
    /// 三角形
    /// </summary>
    public class Triangle : Shape
    {
        #region 属性
        public double Bottom
        {
            get;
            set;
        }
        public double Height
        {
            get;
            set;
        }
        #endregion


        public override double area()
        {
            return Bottom * Height / 2;
        }
    }
}
