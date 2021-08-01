using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Favorite_Things.Animals
{
    class Cats
    {
        public string TypeOfCat { get; set; }
        public int LenghtOfCat { get; set; }


        public Cats(string typeofcat, int lengthofcat)
        {
            TypeOfCat = typeofcat;
            LenghtOfCat = lengthofcat;
        }
        public void Observed()
        {
            Console.WriteLine($"The feline observed was a {TypeOfCat} and body length of {LenghtOfCat} feet long.");
        }
    }
}
