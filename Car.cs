using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7Ex1Won7
{
    internal class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int fabricationYear {  get; set; }
        public Engine engine { get; set; }
        public NumberOfDoors numberOfDoors { get; set; }

        public Car(string brand, string model, int fabricationYear, Engine engine, NumberOfDoors numberOfDoors)
        {
            this.brand = brand;
            this.model = model;
            this.fabricationYear = fabricationYear;
            this.engine = engine;
            this.numberOfDoors = numberOfDoors;
        }

        public string GetDescription()
        {
            return $" Brand: { brand} \n Model: {model} \n Fabrication year: {fabricationYear} \n Engine Size: {engine.engineSize} \n "+
                $"Engine power: {engine.power} \n Combustible type: {engine.combustibleType} \n Number of doors: {numberOfDoors.numberOfDoors}";
        }

        public string StartCar()
        {
            string startEngineMessage = Engine.EngineStart();
            string closeDoorsMessage = NumberOfDoors.CloseDoors();
            return $"The car is starting ... {startEngineMessage} {closeDoorsMessage}";
        }

        public string StopTheCar()
        {
            string stopEngineMessage = Engine.EngineOff();
            string openDoorsMessage = NumberOfDoors.OpenDoors();
            return $"The car has stoped ... {stopEngineMessage} {openDoorsMessage}";
        }
    }
}
