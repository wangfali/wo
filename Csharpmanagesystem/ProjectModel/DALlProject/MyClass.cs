using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALProject
{
    public class MyClass : DALSuper
    {
        public override int add(object obj)
        {
            if (obj == null) return 0;
            //SqlConnection conn = null;
            try
            {
                /*将obj对象转换成model层的学生对象*/
                ModelProject.MyClass cl = (ModelProject.MyClass)obj;
                if (cl.Clno == null) return 0;
                if (cl.Clname == null) return 0;
                if (cl.major1.Prono == null) return 0;
                if (cl.Cltea == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "insert into myClass values ('" + cl.Clno + "','" + cl.Clname + "','" + cl.major1.Prono + "','" + cl.Cltea + "')";

                return sql.sqlCommand(cmd, false);

            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
            }
        }
        public override int edit(object obj)
        {
            if (obj == null) return 0;
            //SqlConnection conn = null;
            try
            {
                /*将obj对象转换成model层的学生对象*/
                ModelProject.MyClass cl = (ModelProject.MyClass)obj;
                if (cl.Clno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "update myClass set Clname='" + cl.Clname + "',Prono='" + cl.major1.Prono + "',Cltea='" + cl.Cltea + "' where Clno='" + cl.Clno + "'";
                return sql.sqlCommand(cmd, false);

            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
            }
        }
        public override int del(object obj)
        {
            if (obj == null) return 0;
            //SqlConnection conn = null;
            try
            {
                /*将obj对象转换成model层的学生对象*/
                ModelProject.MyClass cl = (ModelProject.MyClass)obj;
                if (cl.Clno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "delete from myClass where Clno='" + cl.Clno+"'";
                return sql.sqlCommand(cmd, false);

            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
            }
        }
        /// <summary>
        /// 返回查询用户的信息，通过视图View_class查找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override object getMe(string id)
        {
            System.Data.DataTable dtResult = find("Clno='" + id + "'");
            if (dtResult == null || dtResult.Rows.Count == 0) return null;

            ModelProject.MyClass cl = new ModelProject.MyClass();
            cl.Clno = id;
            cl.Clname = dtResult.Rows[0]["Clname"].ToString();
            cl.major1 = new ModelProject.Major();
            cl.major1.Prono = dtResult.Rows[0]["Prono"].ToString();
            cl.Cltea = dtResult.Rows[0]["Cltea"].ToString();

            return cl;
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
            String cmd = "select * from Myclass where " + condition;

            DBSQL sql = new DBSQL();
            return sql.dbToDT(cmd, false);
        }
    }
}
