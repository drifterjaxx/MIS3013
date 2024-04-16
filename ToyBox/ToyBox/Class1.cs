using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyClass
{

    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes { get; set; }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int num = rand.Next(1, 25);
            return Manufacturer.Substring(0, 1).ToUpper() + num.ToString();
        }

        public void AddNotes()
        {
            Console.WriteLine("Would you like to add notes to the toy?");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine("What notes would you like to add?");
                Notes = Console.ReadLine();
                Console.WriteLine("Notes added!");
            }
            else
            {
                Console.WriteLine("No notes added.");
            }
        }

        public string GetNotes()
        {
            return Notes;
        }
    }
}
