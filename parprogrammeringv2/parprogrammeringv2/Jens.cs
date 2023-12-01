using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammeringv2
{
    internal class jens
    {

        public jens(string name, int age,  string hobby)
        {
            Name = name;
            Age = age;
            Hobby = hobby;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }
    }
}
