using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
   public  class Course:BLLSuper
    {
       /// <summary>
       /// 应用层与数据库层之间创建课程对象
       /// </summary>
       public Course ()
       {
           DAL = new DALProject.Course();
       }
    }
}
