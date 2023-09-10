using System.Runtime.ExceptionServices;
using System.Transactions;

public class Program
{

    public static void Main()
    {
        SimpleIfStatement();


        // toate metodele invocate trebuie sa fie statice pentru a putea fi apelate 

        // nested if 

       


    }
    public static void SimpleIfStatement()
    {
        int x = 2;

        if (x > 3)
        {
            // ramura yes; conditia mea a fost indeplinita 

            Console.WriteLine("X is greater than  3 ");
        }
        else
        {
            // ramura no; Conditia nu e indeplinita!

            Console.WriteLine("X is smaller or equl than 3");
        }

        if (x == 3)
        // un singur egal inseamna atribuire 
        // daca sunt == ii verifica egalitatea
        {
            Console.WriteLine("X is equal to 3");
        }
    }

    public static void NestedIf()
    {
        int first = 5;
        int second = 3;

        if (first == second)
        {
            Console.WriteLine("These two are equal");
        }
        else
        {
            if (first > second)
            {
                Console.WriteLine("First is greater");
            }
            else
            {
                Console.WriteLine("Second is greater");
            }
        }
    }

    public static void AvoidNestedif()
    {
        int first = 5;
        int second = 3;


    }
}