using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{

    /// </summary>
    /// 类名：课表
    /// 描述：基本描述课表的信息
    /// 作者：李洋
    /// 日期：2016年6月30日
    /// 版本2.0.0.0
    /// </summary>
    public class List : ModelSuper
    {
        public enum EWeek { 星期一, 星期二, 星期三, 星期四, 星期五, 星期六, 星期日 }
        public enum whether4 { 上学期, 下学期 }//创建课程枚举
        #region 成员变量

        private String listno;//课程表编号
        private String term;//上课学期
        private EWeek week;//上课时间
        private int jieshu;//上课节数
        private string myClass;//上课班级
        private Classroom room;//教室编号
        private Course course;//课程名 教师名
        public DateTime date = DateTime.Now;//开学日期

        #endregion
        #region  属性定义

        /// <summary>
        /// 上课班级
        /// </summary>
        public string Myclass { get; set; }
        /// <summary>
        /// 上课学期
        /// </summary>
        public string Term { get; set; }
        /// <summary>
        /// 设置课程名称 教师名
        /// </summary>
        public Course course1 { get; set; }
        /// <summary>
        /// 设置上课时间
        /// </summary>
        public EWeek Week { get; set; }
        /// <summary>
        /// 上课节数
        /// </summary>
        public int Jieshu { get; set; }
        /// <summary>
        /// 设置教室编号
        /// </summary>
        public Classroom classroom1 { get; set; }
        /// <summary>
        /// 课表编号
        /// </summary>
        public string Listno { get; set; }
        #endregion
    }
}
