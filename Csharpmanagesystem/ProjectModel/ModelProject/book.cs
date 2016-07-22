using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
  public class book:ModelSuper
    {
      public String idbn { get; set; }
      public decimal price { get; set; }
      public string author { get; set; }
      
    }
}
