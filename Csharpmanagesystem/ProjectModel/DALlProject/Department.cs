using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    /// <summary>
    ///类名：部门类 
    ///描述：对部门对象信息进行数据库操作
    ///作者 ：黄彬
    /// 创建日期：2016.7.7
    /// 版本:2.0.0.0
    /// </summary>
    public class Department:DALSuper
    {
        /// <summary>
        /// 添加部门信息对数据库的操作
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override int add(object obj)
        {
            if (obj == null) return 0;
            //SqlConnection conn = null;
            try
            {
                /*将obj对象转换成model层的学生对象*/
                ModelProject.Department de = (ModelProject.Department)obj;
                if (de.Depno == null) return 0;
                if (de.Depname == null) return 0;
                if (de.Depma == null) return 0;
                if (de.Depfunctian == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "insert into Department(Depno,Depname,Depma,Depfunction) values('" + de.Depno + "','" + de.Depname + "','" + de.Depma + "','" + de.Depfunctian + "')";
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 更新部门信息对数据库的操作
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override int edit(object obj)
        {
            if (obj == null) return 0;
            //SqlConnection conn = null;
            try
            {
                /*将obj对象转换成model层的学生对象*/
                ModelProject.Department de = (ModelProject.Department)obj;
                if (de.Depno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "update Department set Depname='" + de.Depname + "',Depma='" + de.Depma + "',Depfunction='" + de.Depfunctian+ "',Depjob='" + de.Depjob + "',Depchecking='" + de.Depchecking+"'where Depno='"+de.Depno+"'";
                return sql.sqlCommand(cmd, false);

            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 删除部门信息对数据库的操作
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override int del(object obj)
        {
            if (obj == null) return 0;
            //SqlConnection conn = null;
            try
            {
                /*将obj对象转换成model层的学生对象*/
                ModelProject.Department de = (ModelProject.Department)obj;
                if (de.Depno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "delete from Department where Depno='"+de.Depno+"'";
                return sql.sqlCommand(cmd, false);

            }
            catch (Exception)
            {
                return 0;
            }
        }
       /// <summary>
        /// 返回查询用户的信息，通过视图vm_Department查找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override object getMe(string id)
        {
            System.Data.DataTable dtResult = find("Depno='" + id + "'");
            if (dtResult == null || dtResult.Rows.Count == 0) return null;

            ModelProject.Department dep = new ModelProject.Department();
            dep.Depno = id;
            dep.Depname =dtResult.Rows[0]["Depname"].ToString();
            dep.Depma = dtResult.Rows[0]["Depma"].ToString();
            dep.Depfunctian = dtResult.Rows[0]["Depfunctian"].ToString();
            dep.Depjob = dtResult.Rows[0]["Depjob"].ToString();
            dep.Depchecking = dtResult.Rows[0]["Depchecking"].ToString();
            dep.Depnum=Convert.ToInt32(dtResult.Rows[0]["Depnum"]);
            return dep;
        }
        /// <summary>
        /// 查找数据集里是否存在该用户
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public override System.Data.DataTable find(string condition)
        {
          /*  if (condition.Trim() == "")
                condition = "1=1";
            String cmd = "select * from Student where " + condition;
            DBSQL sql = new DBSQL();
            return sql.dbToDT(cmd, false);*/
            if (condition.Trim() == "")
                condition = "1=1";
            String cmd = "select * from Department where " + condition ;
            DBSQL sql = new DBSQL();
            return sql.dbToDT(cmd, false);
        }
    }

    }

