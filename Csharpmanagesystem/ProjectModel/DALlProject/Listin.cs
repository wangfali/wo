using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    /// <summary>
    /// 类名：课表内部类
    /// 概况：对课表内部类对象进行数据库操作
    /// 作者；李洋
    /// 日期；2016年7月7日
    /// 版本；2.0.0.0
    /// </summary>
  public class Listin:DALSuper
    {
      /// <summary>
      /// 添加课表内部类的信息
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
              ModelProject.Listin listin = (ModelProject.Listin)obj;
              
              DBSQL sql = new DBSQL();
              string cmd = "insert into Listin vaules('" + listin.Time + "','" + listin.Evaluate + "','" + listin.course.curno + "')";
              return sql.sqlCommand(cmd, false);
          }
          catch (Exception)
          {
              return 0;
          } 
      }
      /// <summary>
      /// 删除课表内部类的信息
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
              ModelProject.Listin listin = (ModelProject.Listin)obj;
              if (listin.course.curno == null) { return 0; }
              DBSQL sql = new DBSQL();
              string cmd = "delect from Listin where Curno='" + listin.course.curno + "'";
              return sql.sqlCommand(cmd, false);
          }
          catch (Exception)
          {
              return 0;
          }
      }
      /// <summary>
      /// 更新课表内部类信息
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
              ModelProject.Listin listin = (ModelProject.Listin)obj;
              if (listin.course.curno == null) { return 0; }
              DBSQL sql = new DBSQL();
              string cmd = "update  Listin set Curno='" + listin.course.curno + "',Time='" + listin.Time + "',Evaluate='"+listin.Evaluate+"'";
              return sql.sqlCommand(cmd, false);
          }
          catch (Exception)
          {
              return 0;
          }
      }
      /// <summary>
      /// 返回查询用户的信息，通过视图vm_Listin查找
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
      public override object getMe(string id)
      {
          System.Data.DataTable dtResult = find("Curno='" + id + "'");
          if (dtResult == null || dtResult.Rows.Count == 0) return null;

          ModelProject.Listin listin = new ModelProject.Listin();
          listin.course.curno = id;
          listin.Evaluate = dtResult.Rows[0]["Evaluate"].ToString();
          if (dtResult.Rows[0]["Time"].ToString() == "第一二节")
              listin.Time = ModelProject.Listin.TIME.第一二节;
          if (dtResult.Rows[0]["Time"].ToString() == "第三四节")
              listin.Time = ModelProject.Listin.TIME.第三四节;
          if (dtResult.Rows[0]["Time"].ToString() == "第五六节")
              listin.Time = ModelProject.Listin.TIME.第五六节;
          if (dtResult.Rows[0]["Time"].ToString() == "第七八节")
              listin.Time = ModelProject.Listin.TIME.第七八节;
          return listin;
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
          String cmd = "select * from Listin where " + condition;

          DBSQL sql = new DBSQL();
          return sql.dbToDT(cmd, false);
      }


    }
}
