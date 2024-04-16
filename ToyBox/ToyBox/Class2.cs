using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyClass;

namespace ToyBoxClass
{
    public class Toybox
    {
        public List<Toy> Toys { get; set; }
        public string Owner { get; set; }
        public string Location { get; set; }

        public Toybox()
        {
            Toys = new List<Toy>();
            Owner = "";
            Location = "";
        }

        public Toy GetRandomToy()
        {
            Random rand = new Random();
            int num = rand.Next(0, Toys.Count);
            return Toys[num];
        }
    }
}
