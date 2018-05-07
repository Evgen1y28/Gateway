using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RouterLibrary
{
    public class RouterDel : LocalNet 
    {
        public RouterDel(string name, int id) : base(name, id)
        {
            Name = name;
            Id = id;
        }
        
    }
}
