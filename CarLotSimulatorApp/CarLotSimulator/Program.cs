using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            CarLot cl = new CarLot();
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car();
            car1.Year = 2020;
            car1.Make = "Honda";
            car1.Model = "Accord";
            car1.EngineNoise = "VROOM";
            car1.HonkNoise = "HONK HONK";
            car1.IsDriveable = true;
            car1.MakeHonkNoise(car1.HonkNoise);
            car1.MakeEngineNoise(car1.EngineNoise);

            var car2 = new Car();
            car2.Year = 2000;
            car2.Make = "Ford";
            car2.Model = "Mustang";
            car2.EngineNoise = "VROOM VROOM";
            car2.HonkNoise = "HONK";
            car2.IsDriveable = true;
            car2.MakeHonkNoise(car2.HonkNoise);
            car2.MakeEngineNoise(car2.EngineNoise);

            var car3 = new Car();
            car3.Year = 2020;
            car3.Make = "Chevy";
            car3.Model = "Tahoe";
            car3.EngineNoise = "Brroooom";
            car3.HonkNoise = "Beep Beep";
            car3.IsDriveable = true;
            car3.MakeHonkNoise(car3.HonkNoise);
            car3.MakeEngineNoise(car3.EngineNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
