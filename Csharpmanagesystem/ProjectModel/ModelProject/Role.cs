using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    /// <summary>
    /// 类名：角色
    /// 描述：描述了角色的基本信息
    /// 作者：王法立
    /// 创建日期：2016-6-30 
    /// 版本：2.0.0.0
    /// </summary>
    public enum ROleName { 管理员,教师,学生}//枚举类型用于标记角色名称
   public  class Role:ModelSuper
    {
        #region 角色变量    
        private string lgRoleId;
        private ROleName roleName = ROleName.教师;//角色名称
        private string remark;//角色描述
        #endregion
        #region 角色属性
        /// <summary>
        /// 读取或输入角色编号
        /// </summary>
        public string  RoleId
        {
            get { return lgRoleId; }
            set { lgRoleId = value; }
        }
        /// <summary>
        /// 读取或输入角色描述
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 读取或输入角色名称
        /// </summary>
        public ROleName RoleName { get; set; }
       
        #endregion
    }
}
