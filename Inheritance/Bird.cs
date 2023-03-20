using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : AnimalClass
    {
        public bool canFly { get; set; }
        public string environmentsLived { get; set; }

        public int wingspan { get; set; }

        public void MakeBirdNnoises () {
            Console.WriteLine("Caw Caw");
        }


    }
}
