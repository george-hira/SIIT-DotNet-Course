using LearningClasses;

namespace Classes_Basics
{
    class Program
    {
        static void Main(string[] args) 
        { 
            // create an object of my class
            // or an instance of Human

            Human person1 = new Human("George", "Hira", "Blue", 26);

            // create 2 objects with full information about themself - firsName and lastName

            Human person2 = new Human("Miru", "Hira", "Brow", 14);
          
            Human person3 = new Human("Mada", "Lungu", "Green", 26);

            Console.ForegroundColor = ConsoleColor.Blue;
            person1.IntroduseMySelf();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;
            person2.IntroduseMySelf();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            person3.IntroduseMySelf();
            Console.ResetColor();

            Human testDefaultConstructor = new Human();
            testDefaultConstructor.IntroduseMySelf();

            Human person4 = new Human("X", "Y", "Dark");
            person4.IntroduseMySelf();

            Human person5 = new Human("Z", "W");
            person5.IntroduseMySelf();

            Human person6 = new Human("^_^");
            person6.IntroduseMySelf();

            Console.ReadKey();

        

        }

    }

}
