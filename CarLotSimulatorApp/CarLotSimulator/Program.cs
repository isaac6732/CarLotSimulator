﻿using System;
using System.Collections.Generic;

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

            CarLot intance = new CarLot();

            Car car1 = new Car();

            car1.Year = 2005;
            car1.Make = "Toyota";
            car1.Model = "Supra";
            car1.EngineNoise = "Vroompaaa";
            car1.HonkNoise = "Supra";
            car1.IsDriveable = true;

            Console.WriteLine($"{CarLot.numbersOfCars}");

            Car car2 = new Car()
            {
                Year = 2004,
                Make = "Subaru",
                Model = "V8",
                EngineNoise = "Sroom",
                HonkNoise = "Subaru",
                IsDriveable = true
            };

            Console.WriteLine($"{CarLot.numbersOfCars}");

            Car car3 = new Car(2024, "Honda", "Civic", "Hroom", "Honda", true);

            Console.WriteLine($"{CarLot.numbersOfCars}");

            intance.ListOfCars.Add(car1);
            intance.ListOfCars.Add(car2);
            intance.ListOfCars.Add(car3);

            foreach (Car item in intance.ListOfCars)
            {
                Console.WriteLine($"{item.Year}");
                Console.WriteLine($"{item.Make}");
                Console.WriteLine($"{item.Model}");
                Console.WriteLine($"{item.IsDriveable}");
            }
            

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

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
