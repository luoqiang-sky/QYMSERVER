using Abp.Dependency;
using Abp.EntityFramework;
using QYMSERVER.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.SQL
{
    public class SqlExecuter : ISqlExecuter, ITransientDependency
    {
        private IDbContextProvider<QYMSERVERDbContext> _dbContextProvider = null;
        public SqlExecuter(IDbContextProvider<QYMSERVERDbContext> dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;//IocManager.Instance.Resolve<IDbContextProvider<OADbContext>>();
        }

        public int Execute(string sql)
        {
            return _dbContextProvider.GetDbContext().Database.ExecuteSqlCommand(sql);
        }

        public Task<List<T>> SqlQuery<T>(string sql) where T : class, new()
        {
            throw new NotImplementedException();
        }

    }
}
