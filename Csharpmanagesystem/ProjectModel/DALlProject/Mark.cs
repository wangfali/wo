using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    /// <summary>
    /// 类名：成绩表类
    /// 描述：对成绩表对象信息进行数据库操作
    /// 作者：黄咏琪
    /// 创建日期:2016年7月7日
    /// 版本：2.0.0.0
    /// </summary>
    public class Mark:DALSuper
    {
        /// <summary>
        /// 添加成绩表信息
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
                ModelProject.Mark m = (ModelProject.Mark)obj;
                if (m.Markno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "insert into Mark values ('" + m.Grade + "','" + m.Markno + "','" + m.student1.Stno + "','" + m.course1.curno + "','" + m.time.ToShortDateString() +"')";
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 删除成绩信息
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
                ModelProject.Mark m = (ModelProject.Mark)obj;
                if (m.Markno == null) { return 0; }
                DBSQL sql = new DBSQL();
                string cmd = "delect from Mark where Narkno='" + m.Markno + "'";
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 更新成绩信息
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
                   ModelProject.Mark m = (ModelProject.Mark)obj;
                   if (m.Markno == null) { return 0; }
                   DBSQL sql = new DBSQL();
                   string cmd = "update Mark set Grade= '" + m.Grade + "',Stno='" + m.student1.Stno + "',testtime='" + m.course1.Curterm + "',Curno='" + m.course1.curno1 + "',where Markno= '"+m.Markno +"'";
                   return sql.sqlCommand(cmd, false);
               }
               catch (Exception)
               {
                   return 0;
               }
           }
           /// <summary>
           /// 返回查询用户的信息，通过视图vm_Mark查找
           /// </summary>
           /// <param name="id"></param>
           /// <returns></returns>
           public override object getMe(string id)
           {
               System.Data.DataTable dtResult = find("Markno='" + id + "'");
               if (dtResult == null || dtResult.Rows.Count == 0) return null;

               ModelProject.Mark mark = new ModelProject.Mark();
               mark.Markno = id;
               mark.Grade = Convert.ToInt32(dtResult.Rows[0]["Grade"]);
               mark.class2 = new ModelProject.MyClass();
               mark.class2.Clno = dtResult.Rows[0]["Clno"].ToString();

               return mark;
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
               String cmd = "select * from Mark where " + condition;
               DBSQL sql = new DBSQL();
               return sql.dbToDT(cmd, false);
           }

        }
    }


