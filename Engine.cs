using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7Ex1Won7
{
    internal class Engine
    {
        public int engineSize { get; set; }
        public string power {  get; set; }
        public string combustibleType {  get; set; }

        public Engine(int engineSize, string power, string combustibleType)
        {
            this.engineSize = engineSize;
            this.power = power;
            this.combustibleType = combustibleType;
        }

        public static string EngineStart()
        {
            return "brr";
        }

        public static string EngineOff()
        {
            return "par poc pac";
        }
    }
}
