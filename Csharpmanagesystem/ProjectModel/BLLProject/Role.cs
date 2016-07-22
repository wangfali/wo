using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject
{
   public  class Role:BLLSuper
    {
        /// <summary>
        /// 应用层与数据库层之间创建角色对象
        /// </summary>
        public Role()
        {
            DAL = new DALProject.Role();
        }
    }
}
