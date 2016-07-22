using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
  public class Teacher:BLLSuper
    {
        /// <summary>
        /// 应用层与数据库层之间的创建教师对象
        /// </summary>
        public Teacher()
        {
            DAL = new DALProject.Teacher();
        }
    }
}
