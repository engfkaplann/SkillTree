using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Adapter.Models.Abstracts
{
    public interface IDatabase
    {
        void Connect();
        void ExecuteQuery(string query);
    }
}
