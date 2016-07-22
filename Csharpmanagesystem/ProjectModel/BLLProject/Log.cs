using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
   public class Log:BLLSuper
    {
        /// <summary>
        /// 应用层与数据库层之间创建用户日志对象
        /// </summary>
        public Log()
        {
            DAL = new DALProject.Log();
        }
    }
}
