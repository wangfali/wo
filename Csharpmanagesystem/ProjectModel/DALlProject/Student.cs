using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    /// <summary>
    /// 类名:学生
    /// 描述：对学生对象信息进行数据库操作
    /// 作者：徐博
    /// 创建日期2016.7.7
    /// 版本2.0.0.0
    /// </summary>
    public class Student:DALSuper
    {
        /// <summary>
        /// 添加学生信息
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
                ModelProject.Student stu = (ModelProject.Student)obj;
                if (stu.Stno == null) return 0;
                if (stu.Stname == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "insert into Student(Stno,Clno,Sttel,Sex,Stbirthday,Stpolitice,StQQ,Stname) values ('"+stu.Stno +"','"+ stu.class2.Clno+"','"+stu.Sttel+"','"+stu.Sex+"','"+stu.Stbirthday.ToShortDateString()+"','"+stu.Stpolitice+"','"+stu.StQQ+"','"+stu.Stname+"')";
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 通过主码更新学生信息
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
               ModelProject.Student stu = (ModelProject.Student)obj;
                if (stu.Stno == null) return 0;
               
                DBSQL sql = new DBSQL();
                String cmd = "update Student set Clno='" + stu.class2.Clno + "',Stname='" + stu.Stname + "',Stmname='" + stu.Stmname + "',Stfname='" + stu.Stfname + "',Sttel='" + stu.Sttel + "',Stadd='" + stu.Stadd + "',Stbirthday='" + stu.Stbirthday.ToShortDateString() + "',StEmail='" + stu.StEmail + "',StQQ='" + stu.StQQ + "',StHobby='" + stu.StHobby + "',Stoldadd='" + stu.Stoldadd + "',Stposition='" + stu.Stposition + "',Steconomy='" + stu.Steconomy + "'where Stno='" + stu.Stno;
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 通过主码删除学生信息
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
                ModelProject.Student stu = (ModelProject.Student)obj;
                if (stu.Stno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "delete from Student where Stno='" + stu.Stno+"'";
                return sql.sqlCommand(cmd, false);

            }
            catch (Exception)
            {
                return 0;
            }
          
        }
        /// <summary>
        /// 通过主码查找数据库中是否存在该对象
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public override System.Data.DataTable find(string condition)
        {
            if (condition.Trim() == "")
                condition = "1=1";
            String cmd = "select * from Student where " + condition;
            DBSQL sql = new DBSQL();
            return sql.dbToDT(cmd, false);
        }
        /// <summary>
        /// 通过主码查找数据库中的学生对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override object getMe(string id)
        {
            System.Data.DataTable dtResult = find("Stno='" + id + "'");
            if (dtResult == null || dtResult.Rows.Count == 0) return null;
            ModelProject.Student student = new ModelProject.Student();
            student.Stno = id;
            student.Stname = dtResult.Rows[0]["Stname"].ToString();
            student.Stadd = dtResult.Rows[0]["Stadd"].ToString();
           // student.Stage = Convert.ToInt32(dtResult.Rows[0]["Age"]);
            student.Stbirthday=Convert.ToDateTime(dtResult.Rows[0]["Stbirthday"]);
            student.Steconomy = dtResult.Rows[0]["Steconomy"].ToString();
            student.StEmail = dtResult.Rows[0]["StEmail"].ToString();
            student.Stfname = dtResult.Rows[0]["Stfname"].ToString();
            student.StHobby = dtResult.Rows[0]["StHobby"].ToString();
            student.Stmname = dtResult.Rows[0]["Stmname"].ToString();
            if (dtResult.Rows[0]["Stpolitice"].ToString() == "群众")
                student.Stpolitice = ModelProject.Student.STPOLITICE.群众;
            if (dtResult.Rows[0]["Stpolitice"].ToString() == "团员")
                student.Stpolitice = ModelProject.Student.STPOLITICE.团员;
            if (dtResult.Rows[0]["Stpolitice"].ToString() == "党员")
                student.Stpolitice = ModelProject.Student.STPOLITICE.党员;
            student.StQQ = dtResult.Rows[0]["StQQ"].ToString();
            student.Sttel = dtResult.Rows[0]["Sttel"].ToString();
            student.Stoldadd = dtResult.Rows[0]["Stoldadd"].ToString();
            student.Stposition = dtResult.Rows[0]["Stposition"].ToString();
            if (dtResult.Rows[0]["Stpolitice"].ToString() == "男")
                student.Sex = ModelProject.Student.SEX.男;
            if (dtResult.Rows[0]["Stpolitice"].ToString() == "女")
                student.Sex = ModelProject.Student.SEX.女;
            //student.Enrollt = Convert.ToDateTime(dtResult.Rows[0]["Enrollt"]);
            student.class2 = new ModelProject.MyClass();
            student.class2.Clno = dtResult.Rows[0]["Clno"].ToString();
            return student;
        }
    }
}
