
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    /// <summary>
    /// 类名：课程
    /// 描述：关于课程的基本信息
    /// 作者：李洋
    /// 日期：2016年7月7日
    /// 版本2.0.0.0
    /// </summary>
   public class Course:DALSuper
    {
       /// <summary>
       /// 添加课程信息
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
               ModelProject.Course course = (ModelProject.Course)obj;
               if (course.curno ==null ) { return 0; }
               DBSQL sql = new DBSQL();
               string cmd = "insert into Course vaules('" + course.curno + "','" + course.Credit + "','" + course.Period + "','" + course.Credit + "','" + course.Curterm + "','" + course.Cstename + "','" + course.Period + "','" + course.Curname + "','" + course.Listno + "')";
               return sql.sqlCommand(cmd, false);
           }
           catch (Exception)
           {
               return 0;
           } 
       }
       /// <summary>
       /// 删除课程信息
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
               ModelProject.Course course = (ModelProject.Course)obj;
               if (course.curno == null) { return 0; }
               DBSQL sql = new DBSQL();
               string cmd = "delect from Course where Curno='" + course.curno + "'";
               return sql.sqlCommand(cmd, false);
           }
           catch (Exception)
           {
               return 0;
           }
       }
       /// <summary>
       /// 通过主码删除课程信息
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
               ModelProject.Course course = (ModelProject.Course)obj;
               if (course.curno == null && course.Curname == null )
                    { return 0; }
               DBSQL sql = new DBSQL();
               string cmd = "update Course set Credit='" + course.Credit + "',Period='" + course.Period +
                   "',Curd='"+course.Curd+"',Curterm='"+course.Curterm+"',Cstename='"+course.Cstename+"',Curno='"+course.curno+"',Prono='"+course.major.Prono+"',Listno='"+course.list.Listno+"'";
               return sql.sqlCommand(cmd, false);
           }
           catch (Exception)
           {
               return 0;
           }
       }
       /// <summary>
       /// 返回查询用户的信息，通过视图vm_Course查找
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public override object getMe(string id)
       {
           System.Data.DataTable dtResult = find("Curno='" + id + "'");
           if (dtResult == null || dtResult.Rows.Count == 0) return null;

           ModelProject.Course course = new ModelProject.Course();
           course.curno = id;
           course.Credit = (float)dtResult.Rows[0]["Credit"];
           course.Period = (float)dtResult.Rows[0]["Preiod"];
           if (dtResult.Rows[0]["Curd"].ToString() == "公共必修")
               course.Curd = ModelProject.Course.whether3.公共必修.ToString();
           if (dtResult.Rows[0]["Curd"].ToString() == "公共选修")
               course.Curd = ModelProject.Course.whether3.公共选修.ToString();
           if (dtResult.Rows[0]["Curd"].ToString() == "专业必修")
               course.Curd = ModelProject.Course.whether3.专业必修.ToString();
           if (dtResult.Rows[0]["Curd"].ToString() == "专业选修")
               course.Curd = ModelProject.Course.whether3.专业选修.ToString();
           if (dtResult.Rows[0]["Curterm"].ToString() == "上学期")
               course.Curterm = ModelProject.Course.whether4.上学期;
           if (dtResult.Rows[0]["Curterm"].ToString() == "下学期")
               course.Curterm = ModelProject.Course.whether4.下学期;
           course.Cstename = dtResult.Rows[0]["Cstename"].ToString();
           course.major = new ModelProject.Major();
           course.major.Prono = dtResult.Rows[0]["Prono"].ToString();
           course.Curname = dtResult.Rows[0]["Curname"].ToString();
           course.list = new ModelProject.List();
           course.list.Listno = dtResult.Rows[0]["Listno"].ToString();
           return course;
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
           String cmd = "select * from Course where " + condition;

           DBSQL sql = new DBSQL();
           return sql.dbToDT(cmd, false);
       }

       
    }
}
