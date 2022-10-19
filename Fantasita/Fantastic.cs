// C# Sources
// Takes Class from Folders
using Fantastic.Characters;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Fantastic
{

    class Program
    {

        static void Main(string[] args)
        {
            Human human01 = new Human();
            human01.name = Console.ReadLine();
            human01.ArrowKnee();
            human01.Hello();

            Elve elve01 = new Elve();
            elve01.name = Console.ReadLine();
            elve01.Hello();
            elve01.ShootArrow();


            human01.ArrowKnee();

            // Wait before closing
            Console.ReadKey();
        }
    }
}
