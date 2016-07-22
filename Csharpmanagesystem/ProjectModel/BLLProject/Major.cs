using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
   public  class Major:BLLSuper
    {
       /// <summary>
       /// 应用层与数据库层之间创建专业对象
       /// </summary>
       public Major()
       {
           DAL = new DALProject.Major();
       }
    }
}
