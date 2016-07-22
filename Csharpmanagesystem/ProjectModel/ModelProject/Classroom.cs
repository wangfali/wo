using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
        /// <summary>
        /// 类名：教室类
        /// 描述：描述教室的基本信息
        /// 作者：黄咏琪
        /// 创建日期:2016年6月30日
        /// 版本：2.0.0.0
        /// </summary>
    public class Classroom:ModelSuper
    {
        public enum MEDIA { 有, 无 };
        public enum AIRCON { 有, 无 };
        
        #region 成员变量
        private string crno;//教室编号
        private int capacity;//容量
        private int buildno;//栋数
        private int floor;//层数
        private MEDIA media;//多媒体
        private AIRCON aircon;//空调
        private List list;//课表编号
        #endregion
        #region 属性定义
        /// <summary>
        /// 教室编号
        /// </summary>
        public string Crno { get { return crno; } set { crno = value; } }
        /// <summary>
        /// 容量
        /// </summary>
        public int Capacity { get { return capacity; } set { capacity = value; } }
        /// <summary>
        /// 栋数
        /// </summary>
        public int Buildno { get; set; }
        /// <summary>
        /// 层数
        /// </summary>
        public int Floor { get; set; }
        /// <summary>
        /// 多媒体
        /// </summary>
        public MEDIA Media { get { return media; } set { media = value; } }
        /// <summary>
        /// 空调
        /// </summary>
        public AIRCON Aircon { get; set; }
        /// <summary>
        /// 课表编号
        /// </summary>
        public List list1 { get; set; }
        #endregion
    }

}
