using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammeringv2
{
    internal class Therese
    {

        public string name {  get; set; }
        public int age { get; set; }
        public string hobby { get; set; }

        public Therese(string name, int age, string hobby)
        {
            this.name = name;
            this.age = age;
            this.hobby = hobby;
        }

        public void Presenter()
        {
            Console.WriteLine($"Mitt navn er {name}. Jeg er {age} år. Hobbyen min er {hobby}.");
        } 

    }
}
