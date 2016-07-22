using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
  public  class Classroom:BLLSuper
    {
      /// <summary>
      /// 应用层与数据库之间创建教室对象
      /// </summary>
      public Classroom()
      {
          DAL = new DALProject.Classroom();
      }
    }
}
