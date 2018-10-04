using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string signal = "o";
            while (signal != "x")
            {
                Console.WriteLine("enter a signal");
                signal = Console.ReadLine();
                Console.WriteLine("received signal:{0}", signal);
                if (signal == "A")
                {
                    Console.WriteLine("fault abort\n\n");
                    break;
                   
                }
                if (signal == "o")
                {
                    Console.WriteLine("all is well");
                    continue;
                }
            }
        }
    }

}
