using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public static class Utility
    {
        public static void WriteColor(this string ext, ConsoleColor background, ConsoleColor foreground)
        {
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;
            Console.WriteLine(ext);
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            var tax = ClassLibrary1.Class1.CalculateTax(233.440m);
            Console.WriteLine(tax);
            Console.ReadLine();

            "Look at the pretty console colors.".WriteColor(ConsoleColor.Red,ConsoleColor.Green);
            //var arr = new string[5];
            //arr.Aggregate <<<<< TaskExtensions methods
            Console.ReadLine();

        }
    }
}
