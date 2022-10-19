// C# Sources
using System.Globalization;
using System.Reflection;
using System.Resources;




namespace Fantastic.Characters
{
    class Elve
    {
        //Gets Resource
        ResourceManager resMgr = new ResourceManager("Fantastic.Resources.TXT", Assembly.GetExecutingAssembly());
        CultureInfo culInfo = CultureInfo.CreateSpecificCulture("en");


        public string name;
        public int health = 200;



        public void Hello()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(name + resMgr.GetString("Elve_Hello",culInfo));
        }

        public void ShootArrow()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(name + resMgr.GetString("ShootArrow",culInfo));
        }
    }
}
