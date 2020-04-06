using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter user input a
            Console.WriteLine("enter a");
            var a = Double.Parse(Console.ReadLine());

            //enter user input b
            Console.WriteLine("enter b");
            var b = Double.Parse(Console.ReadLine());

            //enter user input c
            Console.WriteLine("enter c");
            var c = Double.Parse(Console.ReadLine());

            var addition = (a + b + c);
            //Console.ReadLine();
            Console.WriteLine(addition);

        }
    }
}
