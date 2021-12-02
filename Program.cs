using System;

namespace Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            var std = new Marks(); // std = " Student "
            std.a = 35;
            std.b = 39;
            std.c = 41;
            int obtained = std.sum(std.a, std.b, std.c);
            float avg = std.avrg(std.a, std.b, std.c); // avg = " average marks "
            Console.WriteLine("The obtained marks are : " + obtained);
            Console.WriteLine("The average marks are : " + avg );

        }
    }
}
