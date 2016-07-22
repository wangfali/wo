using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DALProject
{
    /// <summary>
    /// 类名：用户
    /// 描述：对用户的信息进行数据库操作
    /// 作者：王法立
    /// 创建日期：2016-7-7 
    /// 版本：2.0.0.0
    /// </summary>
   public class User:DALSuper
    {
       /// <summary>
       /// 添加用户信息
       /// </summary>
       /// <param name="obj"></param>
       /// <returns></returns>
       public override int add(object obj)
       {
           //SqlConnection conn=null;
           if (obj == null)
           {
               return 0;
           }
           try
           {
               // conn = new SqlConnection("server=SAMSUNG-PC;uid=sa;pwd=111;database=ManageSystem");
               ModelProject.User user = (ModelProject.User)obj;
               if (user.Userid ==null || user.Userpwd == null) { return 0; }
               DBSQL sql = new DBSQL();
               string cmd = "insert into Users values('" + user.Userid + "','" + user.Userpwd + "')";
               return sql.sqlCommand(cmd, false);
              // SqlCommand c = new SqlCommand(cmd, conn);
               //conn.Open();
            //return  c.ExecuteNonQuery();
           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.ToString());
              return 0;
           }
           //finally { conn.Close(); }
       }
       /// <summary>
       /// 删除用户信息
       /// </summary>
       /// <param name="obj"></param>
       /// <returns></returns>
       public override int del(object obj)
       {
           SqlConnection conn = null;
           if (obj == null)
           {
               return 0;
           }
           try
           {
               conn = new SqlConnection("server=SAMSUNG-PC;uid=sa;pwd=111;database=ManageSystem");
               ModelProject.User user = (ModelProject.User)obj;
               if (user.Userid == null) { return 0; }
              // DBSQL sql = new DBSQL();
               string cmd = "delete from Users where Userid='" + user.Userid+ "'";
               //return sql.sqlCommand(cmd, false);
               SqlCommand c = new SqlCommand(cmd, conn);
               conn.Open();
               return c.ExecuteNonQuery();
           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.ToString());
               return 0;
           }
           finally { conn.Close(); }
       }
       /// <summary>
       /// 更新用户信息
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
               ModelProject.User user = (ModelProject.User)obj;
               if (user.Userid == null ||user.Userpwd == null) { return 0; }
               DBSQL sql = new DBSQL();
               string cmd = "update  Users set Userpwd='" + user.Userpwd +"'where Userid='"+user.Userid+"'";
               return sql.sqlCommand(cmd, false);
           }
           catch (Exception)
           {
               return 0;
           } 
       }
       /// <summary>
       /// 返回查询用户的信息，通过视图vm_users查找
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public override object getMe(string  id)
       {
           System.Data.DataTable dtResult = find("Userid='" + id + "'");
           if (dtResult == null || dtResult.Rows.Count == 0) return null;
           ModelProject.User users = new ModelProject.User();
           users.Userid = id;
           users.Userpwd = dtResult.Rows[0]["Userpwd"].ToString();
           return users;
       }
       /// <summary>
       /// 查找数据集里是否存在该用户
       /// </summary>
       /// <param name="condition"></param>
       /// <returns></returns>
       public override System.Data.DataTable find(string condition)
       {
           if (condition.Trim() == "")
               condition = "1=1";
           String cmd = "select * from Users where " + condition;
           DBSQL sql = new DBSQL();
           return sql.dbToDT(cmd,false);
       }
    }
}
