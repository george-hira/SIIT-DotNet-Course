// Write a method that to remove the nth index character from a nonempty string.


static string RemoveCharacter(string input, int index)
{
    if (string.IsNullOrEmpty(input))
    {
        throw new ArgumentNullException("Input string cannot be null or empty!");
    }

    if (index < 0 || index >= input.Length)
    {
        throw new ArgumentOutOfRangeException("Index is out of range!");
    }

    string result = input.Remove(index, 1);
    return result;
}

string input = "Hello, Teacher";
int indexToRemove = 8;
string result = RemoveCharacter(input, indexToRemove);
Console.WriteLine(result);

// Write a method that to remove the characters which have odd index values of a given string.

static void RemoveOddIndex()
{
    Console.WriteLine("Give me a text, please!");
    string inputText = Console.ReadLine();
    string newString = "";

    for (int i = 0; i < inputText.Length; i++)
    {
        if (i % 2 == 0)
        {
            newString += inputText[i];
        }
    }

    Console.WriteLine("Original Text: " + inputText);
    Console.WriteLine("Text with Odd-Indexed Characters Removed: " + newString);
}


RemoveOddIndex();

// Write a method that takes input from the user and displays that input back in upper and lower cases.
static void UpperAndLower()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Give me a text pls! ");
    string text= Console.ReadLine();
    Console.ResetColor();

    string lowerCase = text.ToLower();
    string upperCase = text.ToUpper();


    Console.WriteLine(lowerCase);
    Console.WriteLine(upperCase);
}
UpperAndLower();

// Write a method that reverses a string if it's length is a multiple of 4 (inverseaza).

static void ReverseString()
{
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("Give me another text pls! ");
    Console.ResetColor();

    string input = Console.ReadLine();
    int inputLength = input.Length;
   

    if (inputLength % 4 == 0)
    {
        char[] stringArray = input.ToCharArray();
        Array.Reverse(stringArray);
        string reversedString = new string(stringArray);

        Console.WriteLine("Reversed text:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(reversedString);
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("This text is not multimple of 4! ");
        Console.WriteLine("Original text: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(input);
        Console.ResetColor();
        
    }
}
ReverseString();

// Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.

static void ConvertUpperCase()
{
    Console.WriteLine("Give me another text pls");
    string input = Console.ReadLine();
    int upperCount = 0;
    
     for(int i=0; i<Math.Min(4,input.Length); i++)
    {
        if (char.IsUpper(input[i]))
        {
            upperCount++;
        }
    }

     if (upperCount >= 2)
    {
        Console.WriteLine("We have at least 2 Upper Strings on this text! ");
        string converted = input.ToUpper();
        Console.WriteLine(converted);
    }
    else
    {
        Console.WriteLine("We don't have at least 2 Upper Strings on this text! ");
        Console.WriteLine(input);

    }   

}
ConvertUpperCase();

// Write a method that to remove a newline.

static void RemoveNewLine()
{
    Console.WriteLine("Give me 2 words, please! ");
    string text = Console.ReadLine();

    string withoutLines = text.Replace("\r", "");

    Console.WriteLine("Text without new lines:");
    Console.WriteLine(withoutLines);
}


RemoveNewLine();


