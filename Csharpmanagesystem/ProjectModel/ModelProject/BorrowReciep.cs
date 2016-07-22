using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class BorrowReciep : ModelSuper
    {
        public int Serial { get; set; }
        public Book2 borrowbook { get; set; }
    }
}
