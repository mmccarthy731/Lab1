﻿using System;

namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Use this program to calculate the perimeter, area, and volume of any room using the length, width, and height!");
            Console.ReadLine();

            bool repeat = true;

            while (repeat)
            {
                double length = GetValue("Please enter the length (in feet) of the room: ");
                double width = GetValue("Please enter the width (in feet) of the room: ");
                double height = GetValue("Please enter the height (in feet) of the room: ");

                double perimeter = (2 * length) + (2 * width);
                double area = length * width;
                double volume = length * width * height;

                Console.WriteLine($"\r\nLength: {length} feet\r\nWidth: {width} feet\r\nHeight: {height} feet\r\n\r\nPerimeter: {perimeter} feet\r\nArea: {area} square feet\r\nVolume: {volume} cubic feet\r\n");
                repeat = TryAgain("Would you like to run the program again? (Y or N): ");
            }
        }

        private static double GetValue (string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool success = double.TryParse(input, out double value);
            if (!success || value <= 0)
            {
                Console.Write("Invalid Entry. ");
                return GetValue(message);
            }
            return value;
        }

        private static bool TryAgain (string message)
        {
            Console.Write(message);
            string input = Console.ReadLine().ToUpper();
            if (input == "Y")
            {
                return true;
            }
            else if (input == "N")
            {
                return false;
            }
            else
            {
                Console.Write("Invalid Entry. ");
                return TryAgain(message);
            }
        }
    }
}
