using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Favorite_Things.Places
{
    class Cities
    {
        public string City { get; set; }
        public string State { get; set; }
        //public bool TN { get; set; }

        public Cities(string city, string state)
        {
            City = city;
            State = state;
        }

        public void Vacay()
        {
            Console.WriteLine($"I look forward to visitig the {City} in the gorgouse state of {State}.");
        }


    }
}
