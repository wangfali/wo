using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Circle : Shape
    {
        public double R
        { get; set; }
        public override double area()
        {
            return 3.14 * R * R;
        }
    }
}
