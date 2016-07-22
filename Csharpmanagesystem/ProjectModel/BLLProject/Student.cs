using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
  public   class Student:BLLSuper
    {
        /// <summary>
        /// 应用层与数据库之间创建学生对象
        /// </summary>
        public Student ()
        {
            DAL = new DALProject.Student();
        }
    }
}
