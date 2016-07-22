using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;
using DALProject;
using System.Data;
namespace BLLProject
{
    public class BLLSuper
    {
        #region 属性
        /// <summary>
        /// 设置或获取表示层对象
        /// </summary>
        public ModelSuper Model { get; set; }
        /// <summary>
        /// 设置或获取数据访问层对象
        /// </summary>
        public DALSuper DAL { get; set; }
        #endregion
        #region 方法
        public int add()
        {
            if (Model == null || DAL == null) return 0;
            return DAL.add(Model);
        }
        public int edit()
        {
            if (Model == null || DAL == null) return 0;
            return DAL.edit(Model);
        }
        public int del()
        {
            if (Model == null || DAL == null) return 0;
            return DAL.del(Model);
        }

        public DataTable find(String condition)
        {
            if (DAL == null) return null;
            return DAL.find(condition);
        }

        public Object getMe(String id)
        {
            if (DAL == null) return null;
            return DAL.getMe(id);
        }
        
        #endregion
    }
}
