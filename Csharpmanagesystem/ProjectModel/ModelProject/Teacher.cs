using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
        ///</summary>
        ///类名：教师类
        ///描述：描述教师的基本信息
        ///作者;黄国传
        ///创建日期：2016年06月30日
        ///版本：1.0.0.0
        ///</summary>
    public class Teacher:ModelSuper
    {
        public enum SEX { 男, 女 }
        public enum TEPOLITICE { 群众, 党员, 团员 }
        
        #region 成员变量
        private string teno;//教师编号
        private Department department;//部门编号
        private string tename;//教师名
        private string edu;//学历
        private string prorank;//职称
        private decimal tesal;//薪资
        private string tel;//联系方式
        private string teadd;//家庭住址
        private SEX sex;//性别
        private DateTime tebirthday;//出生日期
        private int teage;//年龄
        private string teimage;//用户头像
        private TEPOLITICE tepolitice;//政治面貌
        private string teemail;//教师邮箱
        private string tqq;//教师QQ
        private string Teoldadd;//教师户口所在地
        private int dtLengthOfService;//教师工龄
        #endregion

        #region 属性
        /// <summary>
        /// 设置获取教师编号
        /// </summary>
        public string Teno { get; set; }
        /// <summary>
        /// 部门编号
        /// </summary>
        public Department department1 { get; set; }
        /// <summary>
        /// 教师名
        /// </summary>
        public string Tename { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public string Edu { get; set; }
        /// <summary>
        /// 职称
        /// </summary>
        public string Prorank { get; set; }
        /// <summary>
        /// 薪资
        /// </summary>
        public decimal Tesal { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string Teadd { get; set; }
        /// <summary>
        /// 教师性别
        /// </summary>
        public SEX Sex { get { return sex; } set { sex = value; } }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Tebirthday { get { return tebirthday; } set { tebirthday = value; } }
        /// <summary>
        ///  年龄
        /// </summary>
        public int Teage { get { return DateTime.Now.Year - tebirthday.Year; } set { teage = value; } }
        /// <summary>
        /// 教师户口所在地
        /// </summary>
        public string TEoldadd { get; set; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public TEPOLITICE Tepolitice { get; set; }
        /// <summary>
        /// 教师邮件
        /// </summary>
        public string TeEmail { get; set; }
        /// <summary>
        /// 教师QQ
        /// </summary>
        public string TQQ { get; set; }
        /// <summary>
        /// 教师头像
        /// </summary>
        public string Teimage { get; set; }
        /// <summary>
        /// 教师工龄 
        /// </summary>
        public int DtLengthOfService { get; set; }
        #endregion

    }

}
