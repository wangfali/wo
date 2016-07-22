using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    ///</summary>
    ///类名：教师类
    ///描述：描述教师的基本信息
    ///作者;黄国传
    ///创建日期：2016年07月7日
    ///版本：2.0.0.0
    ///</summary>
    public class Teacher:DALSuper
    {
        /// <summary>
        /// 添加教师信息
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
                ModelProject.Teacher te = (ModelProject.Teacher)obj;
                if (te.Teno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "insert into Teacher(Teno,Depno,Tename,Edu,Tedsal,Tel,Teadd,Sex,Tebirthday,Teage,Tepolitice,Terank) values ('" + te.Teno + "','" + te.department1.Depno + "','" + te.Tename + "','" + te.Edu + "','" + te.Tesal + "','" + te.Tel + "','" + te.Teadd + "','" + te.Sex + "','" + te.Tebirthday + "','"+te.Teage+"','" + te.Tepolitice + "','" + te.Prorank + "')";
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
        /// 通过主码更新教师内容
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
                ModelProject.Teacher te = (ModelProject.Teacher)obj;
                if (te.Teno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "update Teacher set Depno='" + te.department1.Depno + "',Tename='" + te.Tename + "',Edu='" + te.Edu + "',Tedsal='" + te.Tesal + "',Tel='" + te.Tel + "',Teadd='" + te.Teadd + "',Sex='" + te.Sex + "',Tebirthday='" + te.Tebirthday + "',Teage='" + te.Teage + "',Tepolitice='" + te.Tepolitice + "',Terank='" + te.Prorank + "'where Teno='" + te.Teno + "'";
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
        /// 通过主码删除教师信息
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
               ModelProject.Teacher te = (ModelProject.Teacher)obj;
                if (te.Teno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "delete from Teacher where Teno='" + te.Teno+"'";
                return sql.sqlCommand(cmd, false);

            }
            catch (Exception)
            {
                return 0;
            }
           
        }
        /// <summary>
        /// 通过主码查找数据库中的教师对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        
            public override object getMe(string id)
        {
            System.Data.DataTable dtResult = find("Teno='" + id + "'");
            if (dtResult == null || dtResult.Rows.Count == 0) return null;
            ModelProject.Teacher teacher = new ModelProject.Teacher();
            teacher.Teno= id;
            teacher.Tename = dtResult.Rows[0]["Tename"].ToString();
            teacher.Teadd = dtResult.Rows[0]["Ttadd"].ToString();
            teacher.Tebirthday = Convert.ToDateTime(dtResult.Rows[0]["Tebirthday"]);
            teacher.Tel = dtResult.Rows[0]["Tel"].ToString();
            teacher.Tesal = Convert.ToDecimal(dtResult.Rows[0]["Tedsal"]);
            if (dtResult.Rows[0]["Tepolitice"].ToString() == "群众")
                teacher.Tepolitice = ModelProject.Teacher.TEPOLITICE.群众;
            if (dtResult.Rows[0]["Tepolitice"].ToString() == "团员")
                teacher.Tepolitice = ModelProject.Teacher.TEPOLITICE.团员;
            if (dtResult.Rows[0]["Tepolitice"].ToString() == "党员")
                teacher.Tepolitice = ModelProject.Teacher.TEPOLITICE.党员;
            if (dtResult.Rows[0]["Sex"].ToString() == "男")
                teacher.Sex =ModelProject.Teacher.SEX.男;
            if (dtResult.Rows[0]["Sex"].ToString() == "女")
                teacher.Sex = ModelProject.Teacher.SEX.女;
            teacher.Prorank = dtResult.Rows[0]["Enrollt"].ToString();
            teacher.Edu = dtResult.Rows[0]["Edu"].ToString();
            teacher.department1 = new ModelProject.Department();
            teacher.department1.Depno = dtResult.Rows[0]["Depno"].ToString();
            return teacher;
        }

     
        /// <summary>
        /// 通过条件查找数据库中是否已经存在教师对象
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public override System.Data.DataTable find(string condition)
        {
            if (condition.Trim() == "")
                condition = "1=1";
            String cmd = "select * from Teacher where " + condition;
            DBSQL sql = new DBSQL();
            return sql.dbToDT(cmd, false);
        }
}


}
