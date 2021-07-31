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
        // public bool HasMaine HasMain { get; set; }
        bool isNative;

        public Cats(string typeofcat, int lengthofcat)
        {
            TypeOfCat = typeofcat;
            LenghtOfCat = lengthofcat;
        }
        public void Observed()
        {
            Console.WriteLine($"The feline observed is {TypeOfCat} and was {LenghtOfCat} feet long.");
           // HasMain = HasMain.None;
        }
    }
}
