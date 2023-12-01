using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammeringv2
{
    internal class BokFilm
    {
     
        
       
        

        public void Movie()
        {
            Console.WriteLine("Name a tittel on a movie");
            string tittel = Console.ReadLine();

            Console.WriteLine("Which year was it published");
            string utgivelse = Console.ReadLine();
            Console.WriteLine("choose your catagory");
            string sjanger = Console.ReadLine();
            Console.WriteLine("name of the publisher");
             string forfatter = Console.ReadLine();
             Console.WriteLine($"Title: {tittel}");
             Console.WriteLine($"published: {utgivelse}");
             Console.WriteLine($"catagory: {sjanger}");
             Console.WriteLine($"publisher: {forfatter}");
            
        }
    }

   
}
