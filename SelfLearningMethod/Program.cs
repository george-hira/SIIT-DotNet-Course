// sa cream o metoda care primeste de la utilizator numere si formeaza un array

using System;
using System.Diagnostics.CodeAnalysis;

namespace LerfLearningMethod
{


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Give me 3 numbers pls ");

            string a = Console.ReadLine();
            string b= Console.ReadLine();
            string c = Console.ReadLine();
            
            int aAsInput = Convert.ToInt32(a);
            int basInput = Convert.ToInt32(b);
            int casInput = Convert.ToInt32(c);  


            int sum = aAsInput + basInput + casInput;
            Console.WriteLine("Suma este: "+ sum);

            float media = sum / 3f;

            Console.WriteLine("Media este: " + media);

            if (aAsInput > basInput)
            {
                Console.WriteLine("Primul numar introdus este mai mare");
            }
            else
            {
                Console.WriteLine("Numarul 2 introdus este mai mare decat primul ");
            }

            if (casInput > aAsInput)
            {
                Console.WriteLine("Numrul 3 este mai mare decat numarul 1!");
            }

            else
            {
                Console.WriteLine("Numarul 1 este mai mare decat numarul 3");
            }

            if (basInput> casInput)
            {
                Console.WriteLine("Numarul 2 este mai mare ca nr 3");

            }

            else
            {
                Console.WriteLine("Numarul 3 este mai mare decat numarul 2");
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                  continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("Hello \n C#!");

            


        }

 

       
        
    }

    
}
