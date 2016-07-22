using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public abstract class ModelSuper:Object
    {
        /// <summary>
        /// 设置或获取对象的ID号
        /// </summary>
        public String ID { get; set; }
        /// <summary>
        /// 设置或获取对象名称
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 设置或获取对象的状态
        /// </summary>
        public String Status { get; set; }
        /// <summary>
        /// 将当前对象转换成xml格式
        /// </summary>
        /// <returns></returns>
        public virtual String ToXML()
        {
            return "";
        }
    }
}
