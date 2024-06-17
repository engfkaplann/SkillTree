using SkillTree.Adapter.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Adapter.Models.Concretes
{
    public class MySqlDatabase : IDatabase
    {
        public void Connect()
        {
            Console.WriteLine("MySQL veritabına bağlandı!");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"MySql veritabanında {query} sorgusu çalıştırıldı!");
        }
    }
}
