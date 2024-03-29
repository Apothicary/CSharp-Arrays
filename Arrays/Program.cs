﻿namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare an array to store car brands, with space for three elements
            string[] cars = new string[3];

            // Assign values to array elements
            cars[0] = "Tesla";
            cars[1] = "BMW";
            cars[2] = "Toyota";

            // Iterate through the array and print each car brand
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // Wait for user input before closing the console window
            Console.ReadKey();
        }
    }
}
