// Ex1
// Float or Double?
// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091 ?
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.
double Number1 = 34.567839023;
float Number2 = 12.345F;
double Number3 = 8923.1234857;
float Number4 = 3456.091F;

Console.WriteLine("Nr este :" + Number1 + " Nr 2 este: " + Number2 + " Nr 3 este: " + Number3 + " iar Nr4 este: " + Number4);

// Ex2
// Boolean Variable
// Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. Print it on the console.

bool isFemale = false;

Console.WriteLine("Am I a female? " + isFemale);

// Ex3
// Strings and Objects
// Declare two string variables and assign them with Hello and World.
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

string Hello = " Hello ";
string World = " World! ";
object Object = Hello + "," + World;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(Hello + "," + World);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(Object);
Console.ResetColor();

// Ex4
// Quotes in Strings
// Declare two string variables and assign them with following value:
// The "use" of quotations causes difficulties.
// Do the above in two different ways: with and without using quoted strings.
// Print the variables to ensure that their value was correctly defined.

string Str1 = " The \"use\" of quotations causes difficulties. ";
string Str2 = @" The ""use"" of quotations causes difficulties.";

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(Str1);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(Str2);
Console.ResetColor();

// Ex5
// Exchange Variable Values
// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
// Print the variable values before and after the exchange.

int a = 5;
int b = 10;
int temporary = a;
a = b;
b = temporary;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Before Exchanging");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("After Exchanging");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.ResetColor();

// Ex6
// Employee Data
// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//  First name
// Last name
//  Age (0...100)
//  Gender(m or f)
//  Personal ID number (e.g. 8306112507)
// Unique employee number (27560000…27569999)
// Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
// Use descriptive names. Print the data at the console.

string FirstName = "Amanda";
string LastName = "Johnson";
sbyte Age = 27;
char Gender = 'F';
long PersonalIDNumber = 8306112507;
int UniqueEmployeeNumber = 27569999;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Employee Information: ");
Console.ResetColor();

Console.WriteLine("First name: " + FirstName);

Console.WriteLine("Last Name: " + LastName);

Console.WriteLine("Age: " + Age);

Console.WriteLine("Gender: " + Gender);

Console.WriteLine("Personal ID number: " + PersonalIDNumber);

Console.WriteLine("Unique employee number: " + UniqueEmployeeNumber);
// ex7
// Practice Nullable Types
// Create a new C# project and in it, declare a nullable integer variable (int? num).
//  Assign a null value to the variable (num = null).
//  Print the variable on the console (Console.WriteLine(num)).
//  Add 42 to the variable (num += 5).
//  Print the variable on the console (Console.WriteLine(num)).
//  Assign a value of 10 to the variable (num = 10).
//  Print the variable on the console (Console.WriteLine(num)).

int? num;
num = null;

Console.WriteLine(num);
num += 42;

Console.WriteLine(num);
num = 10;
Console.WriteLine(num);