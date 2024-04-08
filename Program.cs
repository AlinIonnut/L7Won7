
using L7Ex1Won7;

Engine engine = new Engine(1998, "125CP", "diesel");

NumberOfDoors doors = new NumberOfDoors(5);

Car FirstCar = new Car("Seat", "Leon", 2013, engine, doors);

Console.WriteLine(FirstCar.GetDescription());

Console.WriteLine(FirstCar.StartCar());

Console.WriteLine(FirstCar.StopTheCar());