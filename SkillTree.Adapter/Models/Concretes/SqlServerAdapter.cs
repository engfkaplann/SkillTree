using SkillTree.Adapter.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Adapter.Models.Concretes
{
    public class SqlServerAdapter : IDatabase
    {
        private SqlServer _sqlServer;
        public SqlServerAdapter()
        {
            _sqlServer = new();
        }
        public void Connect()
        {
            _sqlServer.OpenConnection();
        }

        public void ExecuteQuery(string query)
        {
            _sqlServer.RunQuery(query);
        }
    }
}
