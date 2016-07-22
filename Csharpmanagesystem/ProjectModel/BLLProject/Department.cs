using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
  public  class Department:BLLSuper
    {
      /// <summary>
      /// 应用层与数据库之间创建部门对象
      /// </summary>
      public Department()
      {
          DAL = new DALProject.Department();
      }
    }
}
