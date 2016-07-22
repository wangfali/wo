using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    /// <summary>
    /// 
    /// </summary>
    public class Users : ModelSuper
    {
        #region 属性
        /// <summary>
        /// 账号属性
        /// </summary>
        public String Number
        { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public String Password
        { get; set; }
        /// <summary>
        /// 用户拥有角色集合
        /// </summary>
        public List<Actor> Actors
        { get; set; }
        #endregion
        #region 方法
        public override string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<Users>");
            sb.AppendLine("<ID>" + ID + "</ID>");
            sb.AppendLine("<Name>" + Name + "</Name>");
            sb.AppendLine("<Number>" + Number + "</Number>");
            sb.AppendLine("<Password>" + Password + "</Password>");
            sb.AppendLine("<Actors>");
            if (Actors != null && Actors.Count > 0)
            {
                foreach (Actor obj in Actors)
                {
                    sb.AppendLine(obj.ToXML());
                }
            }
            sb.AppendLine("</Actors>");
            sb.AppendLine("<Status>" + Status + "</Status>");
            sb.AppendLine("</Users>");
            return sb.ToString();
        }
        #endregion
    }
}
