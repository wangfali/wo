using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
        /// <summary>
        /// 类名：班级类
        /// 描述：描述班级的基本信息
        /// 作者：黄咏琪
        /// 创建日期:2016年6月30日
        /// 版本：2.0.0.0
        /// </summary>
    public  class MyClass:ModelSuper
    {
        
        #region 成员变量
        //需调用专业类中的专业名 学生类中的职务
        private string clno="";//班级编号
        private string clname="";//班级名
        private string cltea="";//班主任
        private Student monitor;//班长
        private Student tmonitor;//团支书
        private Student studym;//学习委员
        private int num;//人数
        private int boynum;//生人数
        private int girlnum=0;//生人数
        private Major major;//专业类
        #endregion
        #region 属性定义
        
        /// <summary>
        /// 班级编号
        /// </summary>
        public string Clno { get { return clno; } set { clno = value; } } 
        /// <summary>
        /// 班级名
        /// </summary>
        public string Clname { get; set; }
        /// <summary>
        /// 从专业中获取专业名
        /// </summary>
        public Major  major1 { get; set; } 
        /// <summary>
        /// 班主任名
        /// </summary>
        public string Cltea { get; set; }
        /// <summary>
        /// 班长名
        /// </summary>
        public Student Monitor { get; set; }
        /// <summary>
        /// 团支书名
        /// </summary>
        public Student Tmonitor { get; set; }
        /// <summary>
        /// 学习委员名
        /// </summary>
        public Student Studym { get; set; }
        /// <summary>
        /// 人数
        /// </summary>
        public int Num { get { return girlnum+boynum; }}
        /// <summary>
        /// 生人数
        /// </summary>
        public int Boynum { get; set; }
        /// <summary>
        /// 生人数
        /// </summary>
        public int Girlnum { get; set; }
        #endregion
    }

}
