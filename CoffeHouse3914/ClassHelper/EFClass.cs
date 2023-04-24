using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeHouse3914.DB;

namespace CoffeHouse3914.ClassHelper
{
    internal class EFClass
    {
        public static KoffeeHouseEntities Context { get; } = new KoffeeHouseEntities();
    }
}
