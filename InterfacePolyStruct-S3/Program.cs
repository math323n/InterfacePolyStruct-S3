
using InterfacePolyStruct_S3.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace InterfacePolyStruct_S3
{
    class Program
    {
        static void Main()
        {
            List<Temperature> temperatures = new List<Temperature>();
            // random number generator
            Random rnd = new Random();

            // Generate 10 temperatures between 0 and 100 randomly.
            for(int i = 1; i <= 10; i++)
            {
                int celsius = rnd.Next(0, 100);
                int fahrenheit = rnd.Next(0, 456);

                Temperature temp = new Temperature(celsius, fahrenheit);

                temperatures.Add(temp);
            }

            // Sort Array.
            temperatures.Sort();

            foreach(Temperature temp in temperatures)
            {
                Console.WriteLine(temp.Celsius);
            }

            // Compare test
            Temperature temptest = new Temperature(18, 23);
            Temperature otherTest = new Temperature(19, 24);
            Console.WriteLine($"compare: {temptest.CompareTo(otherTest)}");

            // clone test
            Temperature cloneTest = (Temperature)temptest.Clone();
            Console.WriteLine(temptest.Celsius);
            Console.WriteLine(cloneTest.Celsius);

            // Equals testing
            Temperature objOne = new Temperature(1, 2);
            object objTwo = new Temperature(1, 2);
            Console.WriteLine("objOne Equals objTwo: " + objOne.Equals(objTwo));
            Console.WriteLine(objOne.ToString());

            Console.WriteLine($"Hashcode for objTwo: {objTwo.GetHashCode()}");
        }
    }
}