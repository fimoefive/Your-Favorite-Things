using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Favorite_Things.Animals
{
    class Owls
    {
        public bool Native { get; set; }
        public string Name { get; set; } 
        public int WingSpan { get; set; }

        public Owls(bool native, string name, int wingspan)
        {
            Native = native;
            Name = name;
            WingSpan = wingspan;
        }

        public void Watch()
        {
            if (Native == true)
            {
                Console.WriteLine($"I saw a {Name} that had a wingspan of {WingSpan} feet.");
               
            }
            else
            {
                Console.WriteLine("Did not observe any owls today.");
               
            }
        }
    }
}
