using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
        /// <summary>
        /// 类名:专业
        /// 描述：介绍专业的基本特征
        /// 作者：李洋
        /// 创建日期：2016.6.29
        /// 版本2.0.0.0
        /// </summary>
    public class Major:ModelSuper
    {
        
        #region 成员变量
        private string proske;//专业概述
        private string prono;//专业编号
        private string proname;//专业名称
        private string  depart;//部门名称
        #endregion
        #region  属性定义
        /// <summary>
        /// 创建部门对象数组的输入输出
        /// </summary>
        public List<ModelProject.Department> departmentList { get; set; }
        /// <summary>
        /// 设置专业编号 
        /// </summary>
        public string  Prono { get; set; }
        /// <summary>
        /// 设置部门名称
        /// </summary>
        public Department department1 { get; set; }
        /// <summary>
        /// 设置专业名称
        /// </summary>
        public string Proname { get; set; }
        /// <summary>
        /// 设置专业概况
        /// </summary>
        public string Proske { get; set; }
        #endregion
    }

}
