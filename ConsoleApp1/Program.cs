using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world! Type some string!");
            string a = Console.ReadLine();
            Console.WriteLine("You have been typing the string ':" + a + "' type other string or exit for stopping the application!");
            while (true)
            {
                a = Console.ReadLine();
                if (a == "exit") {
                    break;
                } else {
                    Console.WriteLine("You have been typing the string ':" + a + "' type other string or exit for stopping the application!");
                }
            }
            
        }
    }
}
