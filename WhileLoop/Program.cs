// ask a user to enter a word 
// than will keep add the letter 'A' to this word in a loop
// as long as length as the result is smaller 

//Console.WriteLine("Enter a word");

//string word = Console.ReadLine();

//while (word.Length < 10)
//{
//    word += 'A';

//    Console.WriteLine(word);
//}

//Console.WriteLine("The while is over. ");



////Using the while loop, implement the CalculateSumOfNumbersBetween method,
////which given two integers called firstNumber and lastNumber,
////should calculate the sum of numbers between them (including the numbers themselves).
////If lastNumber is smaller than firstNumber, the result shall be 0.

////For example:

////    for firstNumber equal to 5 and lastNumber equal to 10, the result should be 45 because this is the sum of numbers 5, 6, 7, 8, 9, 10

////    for firstNumber equal to - 5 and lastNumber equal to 5, the result should be 0 because this is the sum of numbers - 5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5

////    for firstNumber equal to 10 and lastNumber also equal to 10, the result should be 10 because, to the sum, we include the only number, which is 10

////    for firstNumber equal to 5 and lastNumber equal to 4, the result should be 0 because the lastNumber is smaller than firstNumber

////string secondWord;
////do
////{
////    Console.WriteLine("Enter a world longer than 10 letters");
////    secondWord = Console.ReadLine();
////}
////while (secondWord.Length <= 10);


//CalculateSumOfNumbersBetween(1, 3);
//CalculateSumOfNumbersBetween(8, 1);

// int CalculateSumOfNumbersBetween(int firstNumber, 
//    int lastNumber)
// {
//    int currentNumber = firstNumber;
//    int sum = 0;

//    while(currentNumber <= lastNumber)
//    {
//        sum += currentNumber;
//        currentNumber++;

//        Console.WriteLine("$ Sum is " + sum);
//    }
//    return sum;

// }

//Using the do...while loop, implement the RepeatCharacter method,
//which given a character and targetLength,
//should build a string of this character repeated the given number of times.
//The result must contain at least one character,
//so even if the targetLength is zero, the length of the result should be 1.

Console.WriteLine(RepeatCharacter('s', 4));

string RepeatCharacter(char character, int targetLength)
{
    string result = "";
    do
    {
        result += character;

    } while (result.Length < targetLength);
    return result;
    
}

