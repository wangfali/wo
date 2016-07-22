using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    public class Actor:DALSuper
    {
        public override int add(object obj)
        {
            if (obj == null) return 0;//参数为空，不做处理

            ModelProject.Actor actor = null;//保存转换后的角色对象
            /*对传送的参数obj进行转换*/
            try
            {
                actor = (ModelProject.Actor)obj; 
            }
            catch (Exception)
            {
                return -1;
            }
            /*将角色对象转换成字符串SQL指令*/
            //String cmd = "insert into JueSe values ('" + actor.ID + "','"+actor.Name+"')";
            /*创建数据库访问对象*/
            DBSQL sql = new DBSQL();

            SqlCommand command = new SqlCommand();
            command.CommandText = "up_Actor_Add";//upAddActor
            //command.Parameters.AddWithValue("@id", actor.ID);
            //command.Parameters.AddWithValue("@name", actor.Name);
            command.Parameters.AddWithValue("@document", actor.ToXML());
            return sql.sqlCommandSp(command);
           // return sql.sqlCommand(cmd, false);//执行指令

        }

        public override int edit(object obj)
        {
            if (obj == null) return 0;//没有修改的角色对象
            ModelProject.Actor actor = null;
           
            try
            {
              actor = (ModelProject.Actor)obj;//类型转换
            }
            catch (Exception)
            {
                return -1;
            }
            
            /*创建数据库访问对象*/
            DBSQL sql = new DBSQL();

            SqlCommand command = new SqlCommand();
            command.CommandText = "upActor_Edit";

            command.Parameters.AddWithValue("@document", actor.ToXML());
            return sql.sqlCommandSp(command);

            

        }

        public override int del(object obj)
        {
            if (obj == null) return 0;//没有修改的角色对象
            ModelProject.Actor actor = null;

            try
            {
                actor = (ModelProject.Actor)obj;//类型转换
            }
            catch (Exception)
            {
                return -1;
            }

            /*创建数据库访问对象*/
            DBSQL sql = new DBSQL();

            SqlCommand command = new SqlCommand();
            command.CommandText = "upActor_delete";

            command.Parameters.AddWithValue("@document", actor.ToXML());
            return sql.sqlCommandSp(command);
        }

        public override object getMe(string id)
        {
           DataTable dt=find(id);
           if (dt != null && dt.Rows.Count > 0)
           {
               ModelProject.Actor model = new ModelProject.Actor();
               model.ID = dt.Rows[0]["BianHao"].ToString();
               model.Name = dt.Rows[0]["JueSeMingCheng"].ToString();
               return model;
           }
           else
               return null;

        }

        public override System.Data.DataTable find(string condition)
        {
            DBSQL sql = new DBSQL();
            //return sql.dbToDT("select * from JueSe where JueSeMingCheng like '%"+condition+"%'");
            SqlCommand cmd=new SqlCommand();
            cmd.CommandText = "upFindActor";
            cmd.Parameters.AddWithValue("@con", condition);
            DataSet ds= sql.dbToDSSp(cmd, "temp");
            if (ds == null || ds.Tables == null || ds.Tables.Count == 0)
                return null;
            else
                return ds.Tables["temp"];
        }
    }
}
