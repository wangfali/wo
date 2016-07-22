using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
  public   class List:BLLSuper
    {
      /// <summary>
      /// 应用层与数据库之间创建课表对象
      /// </summary>
      public List()
      {
          DAL = new DALProject.List();
      }
    }
}
