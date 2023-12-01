using System.Xml.Linq;

namespace parprogrammeringv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var movie = new BokFilm();
            movie.Movie();

            var Therese = new Therese("Therese", 30, "gaming");
            Therese.Presenter();


            var Karl = new Karl("Karl", 23, "Fishing");

            Console.WriteLine($" Hello, my name is {Karl.Name} ! I am {Karl.Age} years old. My favorite hobby is {Karl.Hobby}");

            var Jens = new jens("Jens ivar", 26,  "gaming");
            Console.WriteLine($"Hei mitt navn er {Jens.Name}, er {Jens.Age} år gammel,  og liker {Jens.Hobby}");
        }
    }
}