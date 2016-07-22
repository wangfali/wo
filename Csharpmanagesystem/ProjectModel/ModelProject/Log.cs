using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{

    /// <summary>
    /// 类名：用户日志
    /// 描述：描述了用户日志的基本信息
    /// 作者：王法立
    /// 创建日期：2016-6-30 
    /// 版本：2.0.0.0
    /// </summary>
    public enum RenkForU { 低,中,高}//枚举类型用于标记日志等级
    public enum whether{有,无}//枚举类型用于标记日志状态
    public class Log:ModelSuper
    {
        #region 用户日志变量
        
        private string strLogid;//日志编号
        private string lgUserid = ""; //
        private string strLogName;//日志名称
        private string strLogRemark;//日志摘要
        
        private whether enumLogta=whether.无;//日志状态
        private DateTime dtLogDate = DateTime.Now;
       
        #endregion
        #region 用户日志属性
        /// <summary>
        /// 输入或输出用户编号
        /// </summary>
        public string Userid { get; set; }
        /// <summary>
        /// 用户对象的引用
        /// </summary>
        public User user { get; set; }
        /// <summary>
        /// 输出日志的状态
        /// </summary>
        public whether Logta { get; set; }
        /// <summary>
        /// 输出用户日志距离现在的时间
        /// </summary>
        public  TimeSpan  LogForNowTime { get { return DateTime.Now-dtLogDate; } }
        /// <summary>
        /// 读取或输入用户日志描述
        /// </summary>
        public string LogRemark { get; set; }
        /// <summary>
        /// 读取或输入用户日志名称
        /// </summary>
        public string LogName { get; set; }
        /// <summary>
        /// 读取或输入用户日志编码
        /// </summary>
        public string Logid { get; set; }
        #endregion
       
    }
}
