using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    public class List : DALSuper
    {
        /// <summary>
        /// 添加课表信息
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
                /*将obj对象转换成model层的学生对象*/
                ModelProject.List list = (ModelProject.List)obj;
                if (list.Listno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "insert into List values ('" + list.course1.curno + "','" + list.classroom1.Crno  + "','" + list.Listno + "','" + list.Term + "'," + list.Jieshu + ",'" + list.date + "','" + list.Myclass + "')";
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 删除课表信息
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
                ModelProject.List list = (ModelProject.List)obj;
                if (list.Listno == null) return 0;
                DBSQL sql = new DBSQL();
                string cmd = "delete from List where Listno='" + list.Listno + "'";
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 更新课表信息
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
                ModelProject.List list = (ModelProject.List)obj;
                if (list.course1.curno == null) return 0;
                if (list.classroom1.Crno == null) return 0;

                if (list.Listno == null) return 0;
                if (list.Term == null) return 0;

                if (list.Myclass == null) return 0;
                DBSQL sql = new DBSQL();
                string cmd = "update  List set Curno='" + list.course1.curno + "',Crno='" + list.classroom1.Crno +"',Term='" + list.Term + "',Jieshu=" + list.Jieshu + ",date='" + list.date.ToShortDateString() + "',Myclass='" + list.Myclass + "'where Listno='" + list.Listno + "'";
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 返回查询用户的信息，通过视图View_list查找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override object getMe(string id)
        {
            System.Data.DataTable dtResult = find("Listno='" + id + "'");
            if (dtResult == null || dtResult.Rows.Count == 0) return null;

            ModelProject.List list = new ModelProject.List();
            list.Listno = id;
            list.Jieshu = Convert.ToInt32(dtResult.Rows[0]["Jieshu"]);
            list.date = Convert.ToDateTime(dtResult.Rows[0]["date"]);
            list.Myclass = dtResult.Rows[0]["Myclass"].ToString();
            list.course1 = new ModelProject.Course();
            list.course1.curno = dtResult.Rows[0]["Curno"].ToString();
            list.classroom1 = new ModelProject.Classroom();
            list.classroom1.Crno = dtResult.Rows[0]["Crno"].ToString();
            if (dtResult.Rows[0]["Week"].ToString() == "星期一")
                list.Week = ModelProject.List.EWeek.星期一;
            if (dtResult.Rows[0]["Week"].ToString() == "星期二")
                list.Week = ModelProject.List.EWeek.星期二;
            if (dtResult.Rows[0]["Week"].ToString() == "星期三")
                list.Week = ModelProject.List.EWeek.星期三;
            if (dtResult.Rows[0]["Week"].ToString() == "星期四")
                list.Week = ModelProject.List.EWeek.星期四;
            if (dtResult.Rows[0]["Week"].ToString() == "星期五")
                list.Week = ModelProject.List.EWeek.星期五;
            if (dtResult.Rows[0]["Week"].ToString() == "星期六")
                list.Week = ModelProject.List.EWeek.星期六;
            if (dtResult.Rows[0]["Week"].ToString() == "星期日")
                list.Week = ModelProject.List.EWeek.星期日;
            if (dtResult.Rows[0]["Term"].ToString() == "上学期")
                list.Term = ModelProject.List.whether4.上学期.ToString();
            if (dtResult.Rows[0]["Term"].ToString() == "下学期")
                list.Term = ModelProject.List.whether4.下学期.ToString();
            return list;
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
            String cmd = "select * from List where " + condition;
            DBSQL sql = new DBSQL();
            return sql.dbToDT(cmd, false);
        }

    }
}
