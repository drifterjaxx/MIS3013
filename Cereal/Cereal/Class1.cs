using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cereals
{
    internal class Cereal
    {
        //Properties
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Cups { get; set; }
        public double Calories { get; set; }


        //Constructor
        public Cereal()
        {
            Manufacturer = "";
            Name = "";
            Cups = 0;
            Calories = 0;
        }

    }
}
