using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
   public  class Listin:BLLSuper
    {
       /// <summary>
       /// 应用层与数据库层之间创建课表内部类对象
       /// </summary>
       public Listin()
       {
           DAL = new DALProject.Listin();
       }
    }
}
