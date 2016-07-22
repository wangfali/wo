using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    /// <summary>
    /// 类名：用户日志
    /// 描述：对用户的日志进行数据库操作
    /// 作者：王法立
    /// 创建日期：2016-7-7 
    /// 版本：2.0.0.0
    /// </summary>
    public  class Log:DALSuper
    {
        /// <summary>
        /// 添加日志的信息数据库操作
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override int add(object obj)
        {

            if (obj == null)
            {
                return 0;
            }
            try
            {
                ModelProject.Log log = (ModelProject.Log)obj;
                if (log.LogName == null) { return 0; }
                DBSQL sql = new DBSQL();
                string cmd = "insert into Logs values ('" + log.Userid + "','" + log.LogName  + "','" + log.Logta + "','" + log.LogRemark + "')";
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            } 
        }
        /// <summary>
        /// 删除用户信息数据库操作
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override int del(object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            try
            {
                ModelProject.Log log = (ModelProject.Log)obj;
                if (log.Logid==null) { return 0; }
                DBSQL sql = new DBSQL();
                string cmd = "delete from Logs where Logid='" + log.Logid + "'";
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            } 
        }
        /// <summary>
        /// 更新用户信息的数据库操作
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override int edit(object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            try
            {
                ModelProject.Log log = (ModelProject.Log)obj;
                if (log.Logid == null) { return 0; }
                DBSQL sql = new DBSQL();
                string cmd = "update  Logs set Logsta='" + log.Logta +  "',LogRemark='" + log.LogRemark + "'";
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            } 
        }
        /// <summary>
        /// 通过主码查找用户日志信息的数据库操作
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override object getMe(string id)
        {
            System.Data.DataTable dtResult = find("Logid='" + id + "'");
            if (dtResult == null || dtResult.Rows.Count == 0) return null;
            ModelProject.Log log = new ModelProject.Log();
            log.Logid = id;
            log.LogName = dtResult.Rows[0]["LogName"].ToString();
            log.LogRemark = dtResult.Rows[0]["LogRemark"].ToString();
            if (dtResult.Rows[0]["Logta"] == "无")
                log.Logta = ModelProject.whether.无;
            if (dtResult.Rows[0]["Logta"] == "有")
                log.Logta = ModelProject.whether.有;
            log.user = new ModelProject.User();
            log.user.Userid = dtResult.Rows[0]["Userid"].ToString();
            
            return log;
        }
        /// <summary>
        /// 通过主码查找用户日志信息是否存在的数据库操作
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public override System.Data.DataTable find(string condition)
        {
            if (condition.Trim() == "")
                condition = "1=1";
            String cmd = "select * from Logs where " + condition ;
            DBSQL sql = new DBSQL();
            return sql.dbToDT(cmd, false);
        }
    }
  
}
