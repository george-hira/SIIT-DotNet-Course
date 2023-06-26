

using System.Data.SqlTypes;

public static class HomeWork
{ // Ex1: Write a program that reads from the console three numbers of type int and prints their sum.
    public static void Main()
    {
        Suma();
        Greatest();
        
    }
    public static void Suma()
    {
        Console.WriteLine("Introdu un numar: ");
        string number1 = Console.ReadLine();
        int numberInt1 = int.Parse(number1);

        Console.WriteLine("Mai introdu un numar: ");
        string number2 = Console.ReadLine();
        int numberInt2 = int.Parse(number2);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Si un al 3 - lea numar te rog:  ");
        Console.ResetColor();
        string number3 = Console.ReadLine();
        int numberInt3 = int.Parse(number3);

        int sum = (numberInt1 + numberInt2 + numberInt3);

        Console.WriteLine("Suma celor 3 numere este: " + sum);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That's right? ");
        Console.ResetColor();

    }

    // Ex2: Write a program that reads five numbers from the console and prints the greatest of them.

    public static void Greatest()
    {
        Console.WriteLine("Let's play another game!");
        int[] numbers = new int[5];

        Console.WriteLine("Introdu 5 numere: ");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int maxNumber = numbers[0];

        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"The greatest number is: {maxNumber}");
        Console.ResetColor();

        // Cu exercitiu asta mi-am prins urechile grav ca a trebuit sa ma uit si cum fac sa scriu acest "for" + librarii.

    }



}