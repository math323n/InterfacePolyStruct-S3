
using InterfacePolyStruct_S3.Entities;
using System;
using System.Collections;

namespace InterfacePolyStruct_S3
{
    class Program
    {
        static void Main()
        {
            ArrayList temperatures = new ArrayList();
            // Initialize random number generator.
            Random rnd = new Random();

            // Generate 10 temperatures between 0 and 100 randomly.
            for(int i = 1; i <= 10; i++)
            {
                int celsius = rnd.Next(0, 100);
                int fahrenheit = rnd.Next(0, 456);

                Temperature temp = new Temperature(celsius, fahrenheit, "test");

                temperatures.Add(temp);
            }

            // Sort Array.
            temperatures.Sort();

            foreach(Temperature temp in temperatures)
            {
                Console.WriteLine(temp.Celsius);
            }


            Temperature temptest = new Temperature(18, 23, "test");
            Temperature otherTest = new Temperature(19, 24, "test");
            Console.WriteLine(temptest.CompareTo(otherTest));

            Temperature cloneTest = (Temperature)temptest.Clone();
            Console.WriteLine(temptest.Celsius);
            Console.WriteLine(cloneTest.Celsius);

            // Equals testing
            Temperature objOne = new Temperature(1, 2, "test");
            object objTwo = new Temperature(1, 2, "test");
            Console.WriteLine("objOne Equals objTwo: " + objOne.Equals(objTwo));
            Console.WriteLine(objOne.ToString());

            Console.WriteLine(objTwo.GetHashCode());
        }
    }
}