

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

// Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.

Console.WriteLine("Enter what is the radius of a circle: ");

string inputR = Console.ReadLine();
decimal r = decimal.Parse(inputR);

decimal pi = (decimal)Math.PI; // casting Math.PI

// the operator * cannot be applied to operands of type 'double' and decimal! 
decimal perimeter = 2 * pi * r;
decimal area = pi * r * r;

Console.WriteLine("The perimeter is: " + perimeter.ToString("0.000")); // to format our decimals
Console.WriteLine("The area is: " + area.ToString("0.000")); // to format our decimals


// Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist that are divisible with 5.
// such that the remainder of their division by 5 is 0.


Console.WriteLine("Give me 2 numbers pls! "); // indication for our user

Console.WriteLine("Number 1: ");

string nr1Input = Console.ReadLine();

Console.WriteLine("Number 2: ");

string nr2Input = Console.ReadLine();


int nr1 = int.Parse(nr1Input);
int nr2 = int.Parse(nr2Input);
int count = 0;

for (int i = nr1; i <= nr2; i++)
{
    if (i % 5 == 0)
    {
        count++;
        Console.WriteLine(count);
    }
}
Console.WriteLine("We have " + count + " numbers between this numbers you get! ");


// Write a program that reads two numbers from the console and prints the greater of them.
// Solve the problem without using conditional statements and with conditional statements.


Console.WriteLine("Give me 2 numbers pls! "); // indication for our user

Console.WriteLine("Number 1: ");
string number1Input = Console.ReadLine();

Console.WriteLine("Number 2: ");
string number2Input = Console.ReadLine();


int nr_1 = int.Parse(number1Input);
int nr_2 = int.Parse(number2Input);

// with conditional statement 

if (nr_1 < nr_2)
{
    Console.WriteLine(nr_2 + " is greater then " + nr_1);
}
else
{
    Console.WriteLine(nr_1 + " is greater then " + nr_2);
}

// without conditional statement 
int greaterMax = Math.Max(nr_1, nr_2);

Console.WriteLine("Without conditional statement " + greaterMax + " is greater!");

// Write a program that reads five integer numbers and prints their sum.
// If an invalid number is entered the program should prompt the user to enter another number(only once)


