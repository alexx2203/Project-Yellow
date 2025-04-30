using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yellow_Project.Classes
{
    internal class Plant
    {
        public string Name;                 // Name of the plant
        public int PlantedOnDay;           // The day the plant was sown
        public int DaysRequiredToGrow;     // How many days it needs to grow
        public int DaysSincePlanted;       // How many days have passed
        public int UnwateredStreak;        // How many days in a row it wasn't watered
        public bool IsWateredToday;        // Was it watered today?
        public bool IsAlive;               // Is the plant still alive?
        public bool IsFullyGrown;          // Has it reached its full growth?
    }
}
