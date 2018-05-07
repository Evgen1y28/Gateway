using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RouterLibrary;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine($"#### To make a choise use numpad keyboard ####");
                Console.WriteLine();
                Console.WriteLine($"1:Added the router. ");
                Console.WriteLine($"2:Show all routers. ");
                Console.WriteLine($"3:Show break routers. ");
                Console.WriteLine($"4:Show work of local net. ");
                ConsoleKey action = Console.ReadKey().Key;

                Console.Clear();
                switch (action)
                {
                    case ConsoleKey.NumPad1:
                        LocalNet.Add();
                        break;
                    case ConsoleKey.NumPad2:
                        LocalNet.Look();
                        break;

                }

                Console.Clear();
            }
            
        }
    }
}
