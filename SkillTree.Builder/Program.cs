using SkillTree.Builder.Models.Concretes;
using System;

namespace SkillTree.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car familyCar = new CarDirector().BuildFamilyCar();
            Car sportCar = new CarDirector().BuildSportCar();

            Console.WriteLine($"Car type {familyCar.Type}");
            Console.WriteLine($"Car type {sportCar.Type}");

            Console.ReadLine();
        }
    }
}
