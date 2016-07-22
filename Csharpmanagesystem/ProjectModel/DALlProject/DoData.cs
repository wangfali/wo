using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    /// <summary>
    /// 名称：操作数据接口
    /// 描述：定义数据常规操作，包括数据的增加、修改、删除和查询操作
    /// 作者：王平华
    /// 日期：2016-4-18
    /// 版本：1.0.0.0
    /// </summary>
    public interface IDoData
    {
        /// <summary>
        /// 名称：对象新增功能
        /// </summary>
        /// <param name="obj">被操作对象</param>
        /// <returns>如果操作成功，返回大于0的整数，否则返回小于0或等于0的整数</returns>
        int add(Object obj);
         int edit(Object obj);
         int del(object obj);
         Object getMe(String id);
         DataTable find(String condition);
    }
}
