using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : AnimalClass
    {
        public bool canSlither { get; set; }

        public string favoriteFood { get; set; }

        public int weight { get; set; }

        public void MakeReptileNoises()
        {
            Console.WriteLine("hsssssss");
        }
    }
}
