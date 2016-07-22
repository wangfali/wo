using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ModelProject
{
        /// <summary>
        /// 类名：成绩表类
        /// 描述：描述成绩表的基本信息 以及成绩录入
        /// 作者：黄咏琪
        /// 创建日期:2016年6月30日
        /// 版本：2.0.0.0
        /// </summary>
    public class Mark:ModelSuper
    {
        
        #region 成员变量
        //调用学生类中学号、学生名 课程类中课程名、学分、学期  班级类中的班级名、人数
        private int grade;//成绩
        private string markno;//成绩表编号
        private Student student;//学生类
        private Course course;//课程类
        private MyClass class1;//班级类
        private DateTime dttime;//考试时间
        #endregion
        #region 属性定义
        /// <summary>
        /// 考试时间
        /// </summary>
        public DateTime time { get; set; }
        /// <summary>
        /// 成绩
        /// </summary>
        public int Grade { get { return grade; } set { grade = GradeAr.Add(value); } }
        /// <summary>
        /// 成绩数组
        /// </summary>
        public ArrayList GradeAr = new ArrayList();
        /// <summary>
        /// 成绩表编号
        /// </summary>
        public string Markno { get; set; }
        /// <summary>
        /// 从学生中获取学号 学生名
        /// </summary>
        public Student student1 { get; set; }
        /// <summary>
        /// 从课程中获取课程名 学分 学期 
        /// </summary>
        public Course course1 { get; set; }
        /// <summary>
        /// 从班级中获取班级名 人数
        /// </summary>
        public MyClass class2 { get; set; }
        #endregion
    }

}
