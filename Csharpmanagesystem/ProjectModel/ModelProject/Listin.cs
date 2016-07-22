using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{  
        /// <summary>
        /// 类名：课表内部类
        /// 概况：描述课表内部信息
        /// 作者；李洋
        /// 日期；2016年7月7日
        /// 版本；2.0.0.0
        /// </summary>
   public class Listin
    {
        public enum TIME { 第一二节,第三四节,第五六节,第七八节,第九十节}
      
        #region 成员变量
        private Course cstename;//教师
        private TIME time=TIME.第一二节;//时间
        private string evaluate;//评价
        private Course curname;//课程名
        private Course Ccourse;//课程类的引用
        
        #endregion
        #region  属性定义
       /// <summary>
       /// 课程类的引用
       /// </summary>
        public Course course{get;set;}
       /// <summary>
       /// 课程名
       /// </summary>
        public Course Curname { get; set; }
       /// <summary>
       /// 设置教师
       /// </summary>
        public Course Cstename { get; set; }
       /// <summary>
       /// 设置时间
       /// </summary>
        public TIME Time { get; set; }
       /// <summary>
       /// 设置评价
       /// </summary>
        public string Evaluate { get; set; }
        #endregion
    }
}
