using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RouterLibrary
{
    public class LocalNet : Routerboard
    {
        public static List<Routerboard> Routers2;
        
        public LocalNet(string name, int id) : base(name, id)
        {
        }

        public static LocalNet New()
        {
            Console.WriteLine($"Enter the model name of router:");
            Name = Console.ReadLine();
            Console.WriteLine($"Enter the model id of router:");
            Id = Convert.ToInt32(Console.ReadLine());
            return new LocalNet(Name, Id);
        }
      
        public static void Add()
        {
            Routers.Add(New());
        }

        

        public static void LocalNetWork () 
        {
            Thread delRouter = new Thread(DelRouter);

            delRouter.Start();
        }

        public static void DelRouter()
        {
            Routers.AddRange(Routers2.ToArray());
            Routers2.Remove(Routers.Last());

            Thread.Sleep(3000);
        }

        
    }
}
