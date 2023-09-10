// // Write a program that reads five integer numbers and prints their sum.
// If an invalid number is entered the program should prompt the user to enter another number(only once)

int[] numbers;
int size;

Console.WriteLine("How many numbers do you want to sum? ");
string sizeInput = Console.ReadLine();

if (!int.TryParse(sizeInput, out size)) // logical negation operator '!';
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    sizeInput = Console.ReadLine(); // Prompt the user to enter the number again
    int.TryParse(sizeInput, out size); // Try parsing again
}

numbers = new int[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    string userInput = Console.ReadLine();

    if (!int.TryParse(userInput, out numbers[i]))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        userInput = Console.ReadLine(); // Prompt the user to enter the number again
        int.TryParse(userInput, out numbers[i]); // Try parsing again
    }
}

int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine("The sum of the numbers is: " + sum);


// Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input

Console.WriteLine("Get a number: ");

string nInput = Console.ReadLine();

int n = int.Parse(nInput);
int suma = 0;

for (int i = 0; i <= n; i++)
{
    suma += i;
}
Console.WriteLine("Sum is:" + suma);

// Write
// a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.

Console.WriteLine("Get a number: ");

string nrInput = Console.ReadLine();

int nr = int.Parse(nrInput);

for (int i = 1; i <= nr; i++)
{
    if (i % 3 != 0 && i % 7 != 0) // use logical operator AND
    {
        Console.WriteLine("Number divisible by 3 and 7 is: " + i);
    }
}

// Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.

int[] numbers5 = new int[5];

Console.WriteLine("Enter 5 integers:");

for (int i = 0; i < 5; i++)
{
    string input = Console.ReadLine();
}
    

int smallest = numbers5[0];
int largest = numbers5[0];

for (int i = 1; i < 5; i++)
{
    if (numbers5[i] < smallest)
    {
        smallest = numbers5[i];
    }

    if (numbers[i] > largest)
    {
        largest = numbers5[i];
    }
}

Console.WriteLine("Smallest number: " + smallest);
Console.WriteLine("Largest number: " + largest);
