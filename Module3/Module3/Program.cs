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
                Console.WriteLine($"1:Added the router. ");
                ConsoleKey action = Console.ReadKey().Key;

                Console.Clear();
                switch (action)
                {
                    case ConsoleKey.NumPad1:
                        LocalNet.New();
                        break;
                    
                }


            }
            
        }
    }
}
