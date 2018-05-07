using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RouterLibrary
{
    public abstract class Routerboard : IEnumerable
    {
        public string Name { get; set; }
        public int Id { get; set; }

        //public Routerboard(string name, int id)
        //{
        //    Name = name;
        //    Id = id;
        //}

        public static List<Routerboard> Routers = new List<Routerboard>();

        public IEnumerator GetEnumerator()
        {
            return Routers.GetEnumerator();
        }
    }
}
