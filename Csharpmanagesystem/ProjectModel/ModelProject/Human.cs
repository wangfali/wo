using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    /// <summary>
    /// 人类
    /// </summary>
    public class Human
    {
        #region 成员变量
        private String strName = "";//姓名
        private char chrSex;//性别
        private String ID = "";//证件号码
        private String strCountry = "";//国籍
        private String strPhone = "";//电话号码
        private String strMobile = "";//移动号码

        #endregion
        #region 属性
        public String Name
        {
            get { return strName; }
            set { strName = value; }
        }
        public String Address
        { get; set; }
        #endregion
    }
}
