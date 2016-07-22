using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{       
        /// <summary>
        /// 类名：课程
        /// 描述：关于课程的基本信息
        /// 作者：李洋
        /// 日期：2016年6月30日
        /// 版本2.0.0.0
        /// </summary>
    public class Course
    {
        
        public enum whether3 { 公共选修,公共必修,专业选修,专业必修}//创建枚举课程
        public enum whether4 { 上学期,下学期}//创建课程枚举
        #region 成员变量
        private float credit;//学分
        private float period;//学时
        private whether3 curd=whether3.公共必修;//课程类型
        private whether4 curterm=whether4.上学期;//开课学期
        private string curname;//课程名称
        private Major proname;//专业名称
        private string intcurno;//课程编号
        private List listno;//课表编号
        private string cstename;//课程老师名
        private Major Mmajor;//专业类型的引用
        private List Llist;//课表类型的引用
        public string curno1;
        #endregion
        #region  属性定义
        /// <summary>
        /// 创建课表对象类型的引用
        /// </summary>
        public List list { get; set; }
        /// <summary>
        /// 创建专业对象的引用
        /// </summary>
        public Major major { get; set; }
        /// <summary>
        /// 创建课程存储数组
        /// </summary>
        public List<ModelProject.List> listitem{ get; set; }
        /// <summary>
        /// 创建专业存储数组
        /// </summary>
        public List<ModelProject.Major> majorlist { get; set; }
        /// <summary>
        /// 设置课程名称
        /// </summary>
        public string Curname { get; set; }
        /// <summary>
        /// 设置课程类型
        /// </summary>
        public string Curd { get; set; }
        /// <summary>
        /// 设置专业名称
        /// </summary>
        public Major Proname { get; set; }
        /// <summary>
        /// 设置课程编号
        /// </summary>
        public string  curno { get; set; }
        /// <summary>
        /// 设置学分
        /// </summary>
        public float Credit { get; set; }
        /// <summary>
        /// 设置学时
        /// </summary>
        public float Period { get; set; }
        /// <summary>
        /// 设置开课学期
        /// </summary>
        public whether4 Curterm { get; set; }
        /// <summary>
        /// 课表编号
        /// </summary>
        public List Listno { get; set; }
        /// <summary>
        /// 课程老师名
        /// </summary>
        public string Cstename { get; set; }
        #endregion
    }
}
