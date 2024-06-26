﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Builder.Models.Concretes
{
    public class CarBuilder
    {
        private Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public CarBuilder SetColor(string color)
        {
            car.Color = color;
            return this;
        }

        public CarBuilder SetEnginePower(int enginePower)
        {
            car.EnginePower = enginePower;
            return this;
        }

        public CarBuilder SetInterior(string interior)
        {
            car.Interior = interior;
            return this;
        }

        public CarBuilder SetType(string type)
        {
            car.Type = type;
            return this;
        }

        public Car Build()
        {
            return car;
        }
    }
}
