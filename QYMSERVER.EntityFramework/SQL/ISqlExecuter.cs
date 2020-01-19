using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.SQL
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISqlExecuter
    {
        /// <summary>
        /// 执行给定的命令
        /// </summary>
        /// <param name="sql">命令字符串</param>
        /// <param name="parameters">要应用于命令字符串的参数</param>
        /// <returns>执行命令后由数据库返回的结果</returns>
        int Execute(string sql);
        /// <summary>
        /// 传入查询sql，返回List<T>数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        Task<List<T>> SqlQuery<T>(string sql) where T : class, new();
    }
}
