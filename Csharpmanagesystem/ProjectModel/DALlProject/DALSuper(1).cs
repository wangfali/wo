using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    public abstract class DALSuper
    {
        public abstract int add(Object obj);
        public abstract int edit(Object obj);
        public abstract int del(object obj);
        public abstract Object getMe(String id);
        public abstract DataTable find(String condition);
        
    }
}
