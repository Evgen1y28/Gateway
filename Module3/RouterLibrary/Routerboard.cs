using System;
using System.Collections.Generic;
using System.Text;

namespace RouterLibrary
{
    public abstract class Routerboard
    {
        public static string Name { get; set; }
        public static int Id { get; set; }

        public Routerboard(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public static List<Routerboard> Routers = new List<Routerboard>();
    }
}
