using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Actor : ModelSuper
    {
        /// <summary>
        /// 将当前对象转换成xml格式
        /// </summary>
        /// <returns></returns>
        public override String ToXML()
        {
            StringBuilder sbTemp = new StringBuilder();
            sbTemp.AppendLine("<Actor>");
            sbTemp.AppendLine("<ID>" + ID + "</ID>");
            sbTemp.AppendLine("<Name>" + Name + "</Name>");
            sbTemp.AppendLine("<Status>" + Status + "</Status>");
            sbTemp.AppendLine("</Actor>");
            return sbTemp.ToString();
        }
    }
}
