using QYMSERVER.EntityFramework;
using EntityFramework.DynamicFilters;

namespace QYMSERVER.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly QYMSERVERDbContext _context;

        public InitialHostDbBuilder(QYMSERVERDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
