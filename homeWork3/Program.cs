// Write a method that reverses a string if it's length is a multiple of 4.


string[] myArray;
Console.WriteLine("Enter the size of the array: ");

string sizeInput = Console.ReadLine();

int size = int.Parse(sizeInput);

Console.WriteLine($"Ok. You want " + sizeInput + " elements");
myArray = new string[size];

Console.WriteLine("Enter the element of the array: ");

for (int i = 0; i < size; i++)
{
    string elementInput = Console.ReadLine();
    myArray[i] = elementInput;

}

Console.WriteLine("Array Elemets: ");

for (int i = 0; i < size; i++)
{
    Console.WriteLine(myArray[i]);
}

int myArrayLength = myArray.Length;


if (myArrayLength % 4 == 0)
{
    Array.Reverse(myArray);

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("This array lenth is multiple of 4! "+ myArray[i]);
    }
}
else
{
    Console.WriteLine("This array is not multiple of 4! ");
}



