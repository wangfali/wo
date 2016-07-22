using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{       
    /// <summary>
    /// 类名
    /// 描述：描述学生的学生属性特征
    /// 作者：徐博
    /// 创建日期2016.6.30
   /// 版本2.0.0.0
    /// </summary>
    public class Student:ModelSuper
    {
        public enum SEX { 男, 女 }
        public enum STPOLITICE { 群众, 党员, 团员 }
       
        #region 成员变量
        private string strclname;//班级名称
        private string stno;//学号
       
        private string stname;//学生姓名
        private string stmname;//母亲名字
        private string stfname;//父亲名字
        private string sttel;//家庭电话号码
        private string stadd;//家庭住址
        private int age;//年龄
        private SEX sex;//性别
        private DateTime stbirthday;//出生日期
        private DateTime enrollt;//入学时间
        private string stimage;//用户头像
        private STPOLITICE stpolitice;//政治面貌
        private string stemail;//学生邮箱
        private string stqq;//学生QQ
        private string sthobby;//学生爱好
        private string stoldadd;//学生户口所在地
        private string stposition;//学生职位
        private string steconomy;//学生家庭经济情况
        #endregion
        #region 属性
        /// <summary>
        /// 输入输出教室名称
        /// </summary>
        public string clname { get; set; }
        /// <summary>
        /// 存储教室数组
        /// </summary>
        public List<ModelProject.MyClass> ClassItem { get; set; }
        /// <summary>
        /// 设置获取学生号
        /// </summary>
        public string Stno { get { return stno; } set { stno = value; } }
        /// <summary>
        /// 班级名
        /// </summary>
        public MyClass class2 { get; set; }
        /// <summary>
        /// 学生名
        /// </summary>
        public string Stname { get; set; } 
        /// <summary>
        /// 学生母亲姓名
        /// </summary>
        public string Stmname { get; set; }
        /// <summary>
        /// 学生父亲姓名
        /// </summary>
        public string Stfname { get; set; } 
        /// <summary>
        /// 联系方式
        /// </summary>
        public string Sttel { get; set; }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string Stadd { get; set; }
        /// <summary>
        /// 设置获取学生年龄
        /// </summary>
        public int Stage { get { return DateTime.Now.Year - stbirthday.Year; } set { age = value; } }
        /// <summary>
        /// 设置获取学生性别
        /// </summary>
        public SEX Sex { get { return sex; } set { sex = value; } }
        /// <summary>
        /// 设置获取学生出生日期
        /// </summary>
        public DateTime Stbirthday { get { return stbirthday; } set { stbirthday = value; } }
        /// <summary>
        /// 入学时间
        /// </summary>
        public DateTime Enrollt { get { return enrollt; } set { enrollt = value; } } 
        /// <summary>
        /// 政治面貌
        /// </summary>
        public STPOLITICE Stpolitice { get; set; }
        /// <summary>
        /// 学生邮件
        /// </summary>
        public string StEmail { get; set; }
        /// <summary>
        /// 学生QQ
        /// </summary>
        public string StQQ { get; set; }
        /// <summary>
        /// 学生爱好
        /// </summary>
        public string StHobby { get; set; }
        /// <summary>
        /// 学生户口所在地
        /// </summary>
        public string Stoldadd { get; set; }
        /// <summary>
        /// 学生头像
        /// </summary>
        public string Stimage { get; set; }
        /// <summary>
        /// 学生职位
        /// </summary>
        public string Stposition { get; set; }
        /// <summary>
        /// 学生家庭经济情况
        /// </summary>
        public string Steconomy { get; set; }
        #endregion
    }

}
