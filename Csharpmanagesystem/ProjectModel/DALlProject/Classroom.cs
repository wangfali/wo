using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    /// <summary>
    /// 类名：教室类
    /// 描述：对用户对象信息进行数据库操作
    /// 作者：黄咏琪
    /// 创建日期:2016年6月30日
    /// 版本：2.0.0.0
    /// </summary>
    public class Classroom:DALSuper
    {
        public override int add(object obj)
        {
            if (obj == null) return 0;
            //SqlConnection conn = null;
            try
            {
                /*将obj对象转换成model层的学生对象*/
                ModelProject.Classroom cr = (ModelProject.Classroom)obj;
                if (cr.Crno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "insert into Student values ('" + cr.Crno + "'," + cr.Capacity + "," + cr.Buildno + "," + cr.Floor + ",'" + cr.Media + "','" + cr.Aircon + "','" + cr.list1.Listno + "')";
                return sql.sqlCommand(cmd, false);

            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 通过主码更新学生对象信息学生
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
                ModelProject.Classroom cr = (ModelProject.Classroom)obj;
                if (cr.Crno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "update Class set Crno='" + cr.Crno + "',Capacity=" + cr.Capacity + ",Buildno=" + cr.Buildno + ",Floor=" + cr.Floor + ",Media='" + cr.Media + "',Aircon='" + cr.Aircon + "',Listno='" + cr.list1.Listno + "'";
                return sql.sqlCommand(cmd, false);

            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 通过主码删除学生对象信息
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
               ModelProject.Classroom cr = (ModelProject.Classroom)obj;
                if (cr.Crno == null) return 0;
                DBSQL sql = new DBSQL();
                String cmd = "delete from Classroom where Crno=" + cr.Crno;
                return sql.sqlCommand(cmd, false);

            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 返回查询用户的信息，通过视图vm_Classroom查找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override object getMe(string id)
        {
            System.Data.DataTable dtResult = find("Crno='" + id + "'");
            if (dtResult == null || dtResult.Rows.Count == 0) return null;

            ModelProject.Classroom cr = new ModelProject.Classroom();
            cr.Crno = id;
            cr.Capacity = Convert.ToInt32(dtResult.Rows[0]["Capacity"]);
            cr.Buildno = Convert.ToInt32(dtResult.Rows[0]["Buildno"]);
            cr.Floor = Convert.ToInt32(dtResult.Rows[0]["Floor"]);
            if (dtResult.Rows[0]["Media"].ToString().Equals("无")==true)
                cr.Media = ModelProject.Classroom.MEDIA.无;
            if (dtResult.Rows[0]["Media"] == "有")
                cr.Media = ModelProject.Classroom.MEDIA.有;
            if (dtResult.Rows[0]["Aircon"] == "无")
                cr.Aircon = ModelProject.Classroom.AIRCON.无;
            if (dtResult.Rows[0]["Aircon"].ToString()=="有")
                cr.Aircon = ModelProject.Classroom.AIRCON.有;
            cr.list1 = new ModelProject.List();
            cr.list1.Listno = dtResult.Rows[0]["Curno"].ToString();
            return cr;
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
            String cmd = "select * from Classroom where " + condition;
            DBSQL sql = new DBSQL();
            return sql.dbToDT(cmd, false);
        }

    }

}
