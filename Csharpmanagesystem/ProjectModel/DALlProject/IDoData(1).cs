using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALlProject
{
    public interface IDoData
    {
 
          int add(Object obj);
          int edit(Object obj);
          int del(object obj);
          Object getMe(String id);
          DataTable find(String condition);
    }
}
