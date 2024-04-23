using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterBunny
{
    internal class Bunny
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string DeliveryDate { get; set; }
        public int BasketSize { get; set; }
        public string EggColor { get; set; }
        public int EggCount { get; set; }
        public string Location { get; set; }
        public string FavoriteColor { get; set; }

        public Bunny()
        {
            Name = "";
            Age = 0;
            DeliveryDate = "";
            BasketSize = 0;
            EggColor = "";
            EggCount = 0;
            Location = "";
            FavoriteColor = "";
        }

        public Bunny(string name, int age)
        {
            Name = name;
            Age = age;
            DeliveryDate = DeliveryDate;
            BasketSize = BasketSize;
            EggColor = EggColor;
            EggCount = EggCount;
            Location = Location;
            FavoriteColor = FavoriteColor;
        }

        //HowManyEasterBaskets method: This method will determine how many Easter baskets the Easter Bunny needs to carry all of their Eggs.
        //Use the Easter Bunnies EggCount and BasketSize to see how many baskets they need to carry all of their eggs.  Round up to the closest whole number.
        public int HowManyEasterBaskets()
        {
            return (int)Math.Ceiling((double)EggCount / BasketSize);
        }

        //ToString method: This method will return a string that has all of the values for the Easter Bunny in a properly formatted string.
        public override string ToString()
        {
            return $"Bunny: {Name}, Age: {Age}, Delivery Date: {DeliveryDate}, Basket Size: {BasketSize}, Egg Color: {EggColor}, Egg Count: {EggCount}, Location: {Location}, Favorite Color: {FavoriteColor}";
        }
    }
}
