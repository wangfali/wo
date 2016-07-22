using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    /// <summary>
    /// 类名:专业
    /// 描述：对专业对象的信息进行数据库操作
    /// 作者：李洋
    /// 创建日期：2016.7.7
    /// 版本2.0.0.0
    /// </summary>
    public class Major:DALSuper
    {
       /// <summary>
       /// 添加专业信息
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
                   ModelProject.Major ma = (ModelProject.Major)obj;
                    if (ma.Prono == null) return 0;
                    if (ma.Proname == null) return 0;
                    DBSQL sql = new DBSQL();
                    String cmd = "insert into Major values ('" + ma.Prono + "','" + ma.Proname + "','" + ma.Proske + "','" + ma.department1.Depno+ "')";
                    return sql.sqlCommand(cmd, false);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        /// <summary>
        /// 通过主码更新专业信息
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
                  ModelProject.Major ma = (ModelProject.Major)obj;
                    if (ma.Prono == null) return 0;
                    if (ma.Proname == null) return 0;
        
                    DBSQL sql = new DBSQL();
                    String cmd = "update Major set Proname='" + ma.Proname + "',Proske='" + ma.Proske + "',Depno='" + ma.department1.Depno + "'where Prono='"+ma.Prono+"'";
                    return sql.sqlCommand(cmd, false);

                }
                catch (Exception)
                {
                    return 0;
                }
            }
        /// <summary>
        /// 通过主码删除专业信息
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
                   ModelProject.Major ma = (ModelProject.Major)obj;
                    if (ma.Prono == null) return 0;
                    DBSQL sql = new DBSQL();
                    String cmd = "delete from Major where Prono='" + ma.Prono+"'";
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
            /// 返回查询用户的信息，通过视图vm_Major查找
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public override object getMe(string id)
            {
                System.Data.DataTable dtResult = find("Prono='" + id + "'");
                if (dtResult == null || dtResult.Rows.Count == 0) return null;

                ModelProject.Major major = new ModelProject.Major();
                major.Prono = id;
                major.Proname = dtResult.Rows[0]["Proname"].ToString();
                major.Proske = dtResult.Rows[0]["Proske"].ToString();
                major.department1 = new ModelProject.Department();
                major.department1.Depno = dtResult.Rows[0]["Depno"].ToString();
                return major;
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
                String cmd = "select * from Major where " + condition;

                DBSQL sql = new DBSQL();
                return sql.dbToDT(cmd, false);
            }
        }

    }
