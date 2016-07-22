using System;
using System.Collections.Generic;
using System.Text;
namespace DALProject
{
    /// <summary>
    /// 配置数据库参数信息
    /// </summary>
    [Serializable]
  public  class DBConfig
    {
        #region var
        private string strService = "";  // 定义服务器名称
        private string strDataBase = ""; //定义数据库名称
        private string strUser = "";  //定义登陆用户名
        private string strPassword = ""; //定义登陆用户密码
        private int intType = 0;  //定义连接类型       
        #endregion
        #region property
        /// <summary>
        /// 连接服务器名称
        /// </summary>
        public string serviceName
        {
            get { return strService; }
            set { strService = value; }
        }
        /// <summary>
        /// 连接数据库名称
        /// </summary>
        public string databaseName
        {
            get { return strDataBase; }
            set { strDataBase = value; }
        }
        /// <summary>
        /// 连接数据库用户名称
        /// </summary>
        public string userName
        {
            get { return strUser; }
            set { strUser = value; }
        }
        /// <summary>
        /// 连接数据库密码
        /// </summary>
        public string password
        {
            get { return strPassword; }
            set { strPassword = value; }
        }
        /// <summary>
        /// 连接数据库类型
        /// </summary>
        public int type
        {
            get { return intType; }
            set { intType = value; }
        }

      #endregion
        #region method
         
        #endregion
    }
}
