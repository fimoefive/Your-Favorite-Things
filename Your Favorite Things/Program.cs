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
            // Cats Class
            var snowLepord = new Cats("Snow Lepord", 5);
            snowLepord.Observed();

            // Owls Class
            var snowOwl = new Owls(true, "Snow Owl", 2);
            snowOwl.Watch();

            // Cities Class
            var tripOne = new Cities("Austin", "Texas");
            tripOne.Vacay();

            var tripTwo = new Cities("San Francisco", "California");
            tripTwo.Vacay();

            // Parks Class
            var outWest = new Parks("Rocky Mountain", "Colorado");
            outWest.WhereAt();
            outWest.Trip();

            var metro = new Parks("Shelby Bottoms", "Nashville");
            metro.WhereAt();
            metro.Trip();

        }

    }
}
