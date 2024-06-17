using SkillTree.Bridge.Models.Abstracts;
using SkillTree.Bridge.Models.Concretes;
using System;

namespace SkillTree.Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice tv = new Television();
            Remote tvKontrol = new(tv);
            tvKontrol.TogglePower(); //TV'yi açar / kapatır
            tvKontrol.IncreaseVolume(); //Sesi aç

            IDevice radio = new Radio();
            Remote radioKontrol = new(radio);
            radioKontrol.TogglePower();
            radioKontrol.IncreaseVolume();

            Console.ReadLine();
        }
    }
}
