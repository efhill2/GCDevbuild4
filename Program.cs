using System;
using System.IO.Pipes;
using System.Threading;

namespace Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;

            do
            {
                Console.WriteLine("~*Room Calculator*~");

                Console.WriteLine("Please enter the lenth of the room.");
                double lenth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the width of the room.");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the height of the room.");
                double height = Convert.ToDouble(Console.ReadLine());

                double perimeter = lenth + width * 2;
                double area = width * lenth;
                double volume = lenth * width * height;

                if (area <= 250)
                {
                    Console.WriteLine($"The rooms area is {area}, perimeter is {perimeter} and volume is {volume}!");
                    Console.WriteLine("This is a small room");
                }
                else if (area > 250 && area < 650)
                {
                    Console.WriteLine($"The rooms area is {area}, perimeter is {perimeter} and volume is {volume}!");
                    Console.WriteLine("This is a medium room");
                }
                else if (area >= 650)
                {
                    Console.WriteLine($"The rooms area is {area}, perimeter is {perimeter} and volume is {volume}!");
                    Console.WriteLine("This is a large room");
                }

                Console.WriteLine("Would you like to calculate another room? (y/n)");
                ans = Console.ReadLine();

            } while (ans == "y" );
        }

    }
}
