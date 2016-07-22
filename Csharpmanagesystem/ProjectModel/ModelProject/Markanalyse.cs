using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
   public class Markanalyse
    {
        /// <summary>
        /// 类名：成绩分析表类
        /// 描述：描述成绩表的基本信息 以及成绩录入
        /// 作者：黄咏琪
        /// 创建日期:2016年6月30日
        /// 版本：2.0.0.0
        /// </summary>
        #region 成员变量
        //调用学生类中的学号、学生名 课程类中的课程名、学分、学期、教师名 班级类中的班级名、人数 成绩表类中的成绩
        private int rank;//排名
        private float greatrate;//优秀率
        private int greatnum;//优秀人数
        private float passrate;//及格率
        private int passnum;//及格人数
        private DateTime testtime;//考试日期
        private Student stu;//学生类
        private Course course;//课程类
        private MyClass class1;//班级类
        private Mark mark;//成绩表类
        private string markanno;//成绩分析表编号
        #endregion
        #region 属性定义
        public string Markanno { get; set; }//成绩分析表编号
        public int Rank { get; set; }//排名
        public Student Stu { get; set; }//从学生中获取学号 学生名
        public Course Course { get; set; }//从课程中获取课程名 学分 学期 教师名
        public MyClass Class1 { get; set; }//从班级中获取班级名 人数
        public Mark Mark { get; set; }//从成绩表中获取成绩
        public void Greatrate(float great, int num) { great = Greatnum; num = new MyClass().Num; Console.Write("{0}%", great / num * 100); }//优秀率
        public void Passrate(float passnum, int num) { passnum = Passnum; num = new MyClass().Num; Console.Write("{0}%", passnum / num * 100); }//及格率
        public int Greatnum { get; set; }//优秀人数
        public int Passnum { get; set; }//及格人数
        private DateTime Testtime { get { return testtime; } set { testtime = value; } }//考试时间
        #endregion
    }
}
