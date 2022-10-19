// C# Sources
using System.Globalization;
using System.Reflection;
using System.Resources;




namespace Fantastic.Characters
{

    class Human
    {
        //Gets Resource
        ResourceManager resMgr = new ResourceManager("Fantastic.Resources.TXT", Assembly.GetExecutingAssembly());
        CultureInfo culInfo = CultureInfo.CreateSpecificCulture("en");

        public string name;
        public int health = 100;


        public void Hello()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(name + resMgr.GetString("Human_Hello", culInfo));
        }

        public void ArrowKnee()
        {

            Random damage = new Random();
            int _damage = damage.Next(100);
            Console.WriteLine("A sudden arrow is with the power of " + _damage + " damage is flying to " + name);
            int _health = health - _damage;


            if (_health > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(name + ": has " + _health + " Health now");

            }
            else if (_damage == 0)
            {
                Console.WriteLine(name + resMgr.GetString("ParryArrow",culInfo));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(name + ": is dead");
            }

        }

    }


}
