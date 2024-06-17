using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Builder.Models.Concretes
{
    public class CarDirector
    {
        public Car BuildSportCar()
        {
            return new CarBuilder()
                .SetColor("Red")
                .SetEnginePower(500)
                .SetInterior("Wool Flooring")
                .SetType("Sport")
                .Build();
        }

        public Car BuildFamilyCar()
        {
            return new CarBuilder()
                .SetColor("Blue")
                .SetType("Family")
                .Build();
        }
    }
}
