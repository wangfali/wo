using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{ 
    /// <summary>
    /// 类名：用户
    /// 描述：描述了用户的基本信息及登录信息
    /// 作者：王法立
    /// 创建日期：2016-6-30 
    /// 版本：2.0.0.0
    /// </summary>
   
    public class User:ModelSuper
    {
        #region 用户变量
        private string  strUserpwd;//用户密码
        private string lgUserid;//用户编号
        #endregion
        #region 用户属性     
        /// <summary>
        /// 获取或输入用户编号
        /// </summary>
        public string  Userid
        {
            get { return lgUserid; }
            set { lgUserid = value; }
        }
        /// <summary>
        /// 获取或输入用户密码
        /// </summary>
         public string Userpwd
        {
          get { return strUserpwd; }
          set { strUserpwd = value; }
        }
        #endregion
    }
}
 