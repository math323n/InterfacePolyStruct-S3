
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
            for(int ctr = 1; ctr <= 10; ctr++)
            {
                int celsius = rnd.Next(0, 100);
                int fahrenheit = rnd.Next(0, 456);

                Temperature temp = new Temperature(celsius, fahrenheit, "test");
   
                temperatures.Add(temp);
            }

            // Sort ArrayList.
            temperatures.Sort();

            foreach(Temperature temp in temperatures)
                Console.WriteLine(temp.Celsius);

            Temperature temptest = new Temperature(18, 23, "test");
            Temperature otherTest = new Temperature(19, 24, "test");
            Console.WriteLine(temptest.CompareTo(otherTest));

            Temperature cloneTest = (Temperature)temptest.Clone();
            Console.WriteLine(temptest.Celsius);
            Console.WriteLine(cloneTest.Celsius);
        }
    }
}