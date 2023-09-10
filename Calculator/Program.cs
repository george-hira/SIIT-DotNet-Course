Console.WriteLine("Hello!");

Console.WriteLine("Input the 1st number: ");

int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the 2nd number: ");

int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do?");

Console.ForegroundColor= ConsoleColor.Blue;
Console.WriteLine("[A]dd numbers ");
Console.ResetColor();

Console.ForegroundColor= ConsoleColor.Red;
Console.WriteLine("[S]ubtract numbers");
Console.ResetColor();

Console.ForegroundColor= ConsoleColor.Green;
Console.WriteLine("[M]ultiply numbers");
Console.ResetColor();

string answer = Console.ReadLine();

if (EqualsCaseInsensitive(answer, "M"))
{
    int result = number1 * number2;
    PrintFinalEquation(number1, number2, result, "*");
}
else if(EqualsCaseInsensitive(answer, "S"))
{
    int result = number1 - number2;
    PrintFinalEquation(number1, number2, result, "-");
}
else if (EqualsCaseInsensitive(answer, "A"))
{
    int result = number1 + number2;
    PrintFinalEquation(number1, number2, result, "+");

}
else
{
    Console.WriteLine("Invalid choice!");
}
Console.WriteLine("Press any key to close!");

Console.ReadKey();

void PrintFinalEquation( int number1, int number2, int result, 
    string @operator)
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

