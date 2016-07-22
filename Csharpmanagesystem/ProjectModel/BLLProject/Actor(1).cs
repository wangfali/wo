using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
    public class Actor : BLLSuper
    {
        public Actor()
        {
            DAL = new DALProject.Actor();
        }
        
    }
}
