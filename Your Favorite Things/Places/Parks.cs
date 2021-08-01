using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Favorite_Things.Places
{
    class Parks
    {
        public string ParkName { get; set; }
        public string Location { get; set; }

        string _nationalPark = "National Park";
        string _statePark = "State Park";
        string _nationalMonument = "National Monument";
        string _cityPark = "City Park";

        public Parks(string name, string location)
        {
            ParkName = name;
            Location = location;
        }

        public void WhereAt()
        {
            if (Location == "Nashville")
            {
                Console.WriteLine($"I enjoyed hiking the trails in the {_cityPark}.");
            }
            else if (Location == "Tennessee")
            {
                Console.WriteLine($"I enjoyed hiking the trails in the {_statePark}.");

            }
            else if (Location == "Colorado")
            {
                Console.WriteLine($"I enjoyed hiking the trails in the {_nationalPark}.");
            }
            else
            {
                Console.WriteLine($"I enjoyed visiting the {_nationalMonument}.");
            }
        }

        public void Trip()
        {
            Console.WriteLine($"I look forward to visitig the {ParkName} in {Location}.");
        }


    }
}
