using Your_Favorite_Things.Animals;
using Your_Favorite_Things.Places;
using System;
using System.Collections.Generic;

namespace Your_Favorite_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            var snowOwl = new Owls(true, "Snow Owl", 2);
            snowOwl.Watch();

            var snowLepord = new Cats("Snow Lepord", 5);
            snowLepord.Observed();
        }

    }
}
