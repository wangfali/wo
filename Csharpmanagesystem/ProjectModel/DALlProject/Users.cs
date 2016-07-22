
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    public class Users:DALSuper
    {
        public override int add(object obj)
        {
            if (obj == null) return 0;//参数为空，不做处理

            ModelProject.Users u = null;//保存转换后的用户对象
            /*对传送的参数obj进行转换*/
            try
            {
                u = (ModelProject.Users)obj;
            }
            catch (Exception)
            {
                return -1;
            }
                      /*创建数据库访问对象*/
            DBSQL sql = new DBSQL();

            SqlCommand command = new SqlCommand();
            command.CommandText = "up_Users_Add";//           
            command.Parameters.AddWithValue("@document", u.ToXML());
            return sql.sqlCommandSp(command);
           
        }

        public override int edit(object obj)
        {
            throw new NotImplementedException();
        }

        public override int del(object obj)
        {
            throw new NotImplementedException();
        }

        public override object getMe(string id)
        {
            DataTable dt = find("ZhangHao='" + id + "'");
            if (dt == null || dt.Rows.Count==0) return null;

            ModelProject.Users u = new ModelProject.Users();
            u.ID = id;
            u.Number = dt.Rows[0]["ZhangHao"].ToString();
            u.Name = dt.Rows[0]["XingMing"].ToString();
            u.Password = dt.Rows[0]["MiMa"].ToString();
            u.Status = dt.Rows[0]["ZhuangTai"].ToString();
            return u;
        }

        public override System.Data.DataTable find(string condition)
        {
            DBSQL sql = new DBSQL();
            return sql.dbToDT("select *,dbo.getJueSe(ZhangHao) as jueSe from YongHu where " + condition); 

        }
    }
}
