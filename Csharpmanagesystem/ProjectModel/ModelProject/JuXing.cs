using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class JuXing : Shape
    {
        public Double Chang { get; set; }
        public Double Kuan { get; set; }
        public override double area()
        {
            return Chang * Kuan;
        }
    }
}
