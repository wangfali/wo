using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{       
        /// <summary>
        ///类名：部门类 
        ///描述：描述部门属性的特征
        ///作者 ：黄彬
        /// 创建日期：2016.6.29
        /// 版本:2.0.0.0
        /// </summary>
    public class Department:ModelSuper
    {
        
        #region 成员变量
        //需调用  教师类中教师名
        private string depno;//部门号
        private string depname;//部门名称
        private string depma;//部门负责人
        private string depfunctian;//部门功能
        private string depmember;//部门成员
        private string depjob;//部门职务
        private string depchecking;//部门考勤
        private int depnum;//部门人数

        #endregion
        #region  属性定义
        /// <summary>
        /// 部门编号
        /// </summary>
        public string Depno { get { return depno; } set { depno = value; } }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string Depname { get; set; }
        /// <summary>
        /// 部门负责人
        /// </summary>
        public string Depma { get; set; }
        /// <summary>
        /// 部门功能
        /// </summary>
        public string Depfunctian { get; set; }
        /// <summary>
        /// 部门成员
        /// </summary>
        public string Depmember { get; set; }
        /// <summary>
        /// 部门职务
        /// </summary>
        public string Depjob { get; set; }
        /// <summary>
        /// 部门考勤
        /// </summary>
        public string Depchecking { get; set; }
        /// <summary>
        /// 部门人数
        /// </summary>
        public int Depnum { get; set; }
        #endregion
    }

}
