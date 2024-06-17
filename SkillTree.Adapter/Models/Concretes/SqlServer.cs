using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Adapter.Models.Concretes
{
    public class SqlServer
    {
        public void OpenConnection()
        {
            Console.WriteLine("SqlServer veritabına bağlandı!");
        }

        public void RunQuery(string query)
        {
            Console.WriteLine($"SqlServer veritabanında {query} sorgusu çalıştırıldı!");
        }
    }
}
