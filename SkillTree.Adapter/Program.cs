using SkillTree.Adapter.Models.Abstracts;
using SkillTree.Adapter.Models.Concretes;
using System;

namespace SkillTree.Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MySql
            IDatabase database1 = new MySqlDatabase();
            database1.Connect();
            database1.ExecuteQuery("Select * From Users");

            //MSSql
            IDatabase database2 = new SqlServerAdapter();
            database2.Connect();
            database2.ExecuteQuery("Select * From Users");
            
            Console.ReadLine();
        }
    }
}
