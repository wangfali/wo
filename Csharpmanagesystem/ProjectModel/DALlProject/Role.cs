using DALProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DALProject
{
    /// <summary>
    /// 类名：角色
    /// 描述：对角色对象信息进行数据库操作
    /// 作者：王法立
    /// 创建日期：2016-7-7 
    /// 版本：2.0.0.0
    /// </summary>
    public  class Role:DALSuper
    {
        /// <summary>
        /// 添加角色信息
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override int add(Object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            try
            {
                ModelProject.Role role = (ModelProject.Role)obj;
                if (role.RoleId ==null) { return 0; }
                DBSQL sql = new DBSQL();
                string cmd = "insert into Role(RoleName,RoleId,remark) values('" + role.RoleName + "','" + role.RoleId + "','" + role.Remark + "')";
               return sql.sqlCommand(cmd, false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
            finally {  }
        }
        /// <summary>
        /// 删除角色信息
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override int del(object obj)
        {
            ModelProject.Role role = (ModelProject.Role)obj;
            if (role.RoleId == null) { return 0; }
            DBSQL sql = new DBSQL();
            string cmd = "delete from Role where RoleId='" + role.RoleId + "'";
            return sql.sqlCommand(cmd, false);
        }
        /// <summary>
        /// 更新角色信息
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
                ModelProject.Role role = (ModelProject.Role)obj;
                if (role.RoleId == null) { return 0; }
                DBSQL sql = new DBSQL();
                string cmd = "update  Role set RoleName='"+role.RoleName+"',remark='"+role.Remark+"'where RoleId='"+ role.RoleId+"'";
                return sql.sqlCommand(cmd, false);
            }
            catch (Exception)
            {
                return 0;
            } 
        }
        /// <summary>
        /// 通过主码查找数据库中的角色对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override object getMe(string id)
        {
            System.Data.DataTable dtResult = find("RoleId='" + id + "'");
            if (dtResult == null || dtResult.Rows.Count == 0) return null;
            ModelProject.Role role= new ModelProject.Role();
            role.RoleId = id;
            if (dtResult.Rows[0]["RoleName"].ToString()=="管理员")
            role.RoleName =ModelProject.ROleName.管理员 ;
            if (dtResult.Rows[0]["RoleName"].ToString() == "教师")
                role.RoleName = ModelProject.ROleName.教师;
            if (dtResult.Rows[0]["RoleName"].ToString() == "学生")
                role.RoleName = ModelProject.ROleName.学生;
            role.Remark = dtResult.Rows[0]["remark"].ToString();
            return role;
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
            String cmd = "select * from Role where " + condition;

            DBSQL sql = new DBSQL();
            return sql.dbToDT(cmd, false);
        }
    }
}