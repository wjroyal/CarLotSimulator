using System;
using System.Reflection;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            var lot = new CarLot();
            //DONE Create a seperate class file called Car
            //DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable



            //DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE The methods should take one string parameter: the respective noise property


            //DONE Now that the Car class is created we can instanciate 3 new cars
            //DONE Set the properties for each of the cars

            Car jeepPatriot = new Car()
            {
                Year = 2017,
                Make = "Jeep",
                Model = "Patriot",
                EngineNoise = "Vroom",
                HonkNoise = "Honk",
                IsDriveable = true,
            };


            lot.Cars.Add(jeepPatriot);
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            Car harleyDyna = new Car();


            harleyDyna.Year = 2009;
            harleyDyna.Make = "Harley Davidson";
            harleyDyna.Model = "FXDF";
            harleyDyna.EngineNoise = "braaap";
            harleyDyna.HonkNoise = "beep";
            harleyDyna.IsDriveable = true;

            lot.Cars.Add(harleyDyna);
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            Car schoolBus = new Car(1995, "Bluebird", "TC2000", "bruuuuum", "Baaa", true);

            lot.Cars.Add(schoolBus);
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            Car chevyPickup = new Car()
            {
                Year = 1993,
                Make = "Chevrolet",
                Model = "1500",
                EngineNoise = "rumble",
                HonkNoise = "Honk",
                IsDriveable = true,
            };

            lot.Cars.Add(chevyPickup);
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");


            //Call each of the methods for each car
            jeepPatriot.MakeEngineNoise(jeepPatriot.EngineNoise);
            jeepPatriot.MakeHonkNoise(jeepPatriot.HonkNoise);

            harleyDyna.MakeEngineNoise(harleyDyna.EngineNoise);
            harleyDyna.MakeHonkNoise(harleyDyna.HonkNoise);

            schoolBus.MakeEngineNoise(schoolBus.EngineNoise);
            schoolBus.MakeHonkNoise(schoolBus.HonkNoise);

            chevyPickup.MakeEngineNoise(chevyPickup.EngineNoise);
            chevyPickup.MakeHonkNoise(chevyPickup.HonkNoise);

            //*************BONUS*************//

            // DONE Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE Create a CarLot class
            //DONE It should have at least one property: a List of cars
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

           


            foreach(var Car in lot.Cars)
            {
                Console.WriteLine($"Year:{Car.Year} Make: {Car.Make} Model: {Car.Model}"); 
            }
        }
    }
}
