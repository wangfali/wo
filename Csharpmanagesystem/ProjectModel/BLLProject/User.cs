using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
   public class User:BLLSuper
    {
       /// <summary>
       ///应用层与数据库层之间用户对象的创建
       /// </summary>
        public User()
        {
            DAL = new DALProject.User();
        }
    }
}
