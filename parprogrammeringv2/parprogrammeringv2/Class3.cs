using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammeringv2
{
    internal class Therese
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }

        public Therese(string name, int age, string hobby)
        {
            Name = name;
            Age = age;
            Hobby = hobby;

        }

        public void Present()
        {
            Console.WriteLine($"Mitt navn er {Name}. Jeg er {Age} år. Hobbyen min er {Hobby}");
        }
    }
}
