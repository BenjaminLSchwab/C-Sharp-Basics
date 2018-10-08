using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    class Animal
    {
        public Animal(string name) : this(name, 4) { }

        public Animal(string name, int numLegs)
        {
            Name = name;
            NumLegs = numLegs;
        }

        public string Name { get; set; }
        public int NumLegs { get; set; }
    }
}
