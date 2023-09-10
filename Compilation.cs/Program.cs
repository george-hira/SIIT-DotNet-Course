var number = 14;

string @randoms = "abcd";
randoms += "e";

Console.WriteLine(randoms);

while (number > 0)
{
    number /= 2;
    Console.WriteLine("Number is: " + number);
}

Console.WriteLine("The loop is finished.");





//using System.ComponentModel;


//int a = 4, b = 2, c = 10;

//Console.WriteLine("First is: " + a + ", second is: " + b +
//    ", third is: " + c);

//Console.WriteLine($" First is: {a}, second is: {b}, third is: {c}");

//Console.WriteLine(FormatDate(2023, 9, 25));

//string FormatDate(int year, int month, int day)
//{
//    return $"{year}/{month}/{day}";
//}

//Console.WriteLine("Hello!");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[A]dd a ");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

//string userInput = "ABC";

//string userChoice = Console.ReadLine();
//Console.WriteLine("User input:" + userChoice);

//int number = 10;

//var isEqual = number < 9 ||(number % 2 == 0 && number < 20);

//Console.WriteLine(isEqual);

//switch (userChoice)
//{
//    case "s":
//    case "S":
//        PrintSelectedOption("See all TODOs");
//        break;
//    case "a":
//    case "A":
//        PrintSelectedOption("Add a TODO");
//        break;
//    case "r":
//    case "R":
//        PrintSelectedOption("Remove a TODO");
//        break;
//    case "e":
//    case "E":
//        PrintSelectedOption("Exit");
//        break;
//    default:
//        Console.WriteLine("Invalid choice!");
//        break;
//}

//if (userChoice == "ABC")

//{
//    Console.WriteLine("User typed ABC");
//}
//else
//{
//    Console.WriteLine("User did not type ABC");
//}

//if (userChoice.Length <=3)
//{
//    Console.WriteLine("Short answer");
//}
//else if (userChoice.Length <10)
//{
//    Console.WriteLine("Medium answer!");
//}
//else
//{
//    Console.WriteLine("Short answer!");
//}

//userChoice = "ABC";
///*
//if (userChoice == "S")
//{
//    PrintSelectedOption("See all TODOs");
//}
//else if (userChoice == "A")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userChoice == "R")
//{
//    PrintSelectedOption("Remove a TODO");

//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exit");
//}
//*/

//var result = Add(10, 5);
//Console.WriteLine("10 + 5 = " + result);


//Console.WriteLine("Provide a number: ");
//string userInput1 = Console.ReadLine();
//int numberProvided = int.Parse(userInput1);
//Console.WriteLine(numberProvided);

//bool isLong = IsLong(userChoice);

//bool IsLong(string input)
//{
//    return input.Length > 10;
//}

//int Add (int a, int b)
//{
//    return a + b;
//}

//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected option: " + selectedOption);
//}


Console.ReadKey();




