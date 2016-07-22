using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
  public   class Mark:BLLSuper
    {
      /// <summary>
      /// 应用层与数据库层之间创建成绩表对象
      /// </summary>
      public Mark()
      {
          DAL = new DALProject.Mark();
      }
    }
}
