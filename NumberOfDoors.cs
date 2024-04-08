using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7Ex1Won7
{
    internal class NumberOfDoors
    {
        public int numberOfDoors {  get; set; }


        public NumberOfDoors(int numberOfDoors)
        {
            this.numberOfDoors = numberOfDoors;
        }

        public static string OpenDoors()
        {
            return "click";
        }

        public static string CloseDoors()
        {
            return "clack";
        }
    }
}
