// Arrays
// toate elementele sunt de acelasi tip 
// ordinea elementelor este fixa 
// in momentul in care avem paranteze patrate [] este un array 
// ca sa initializam array folosim new unde ii specificam lungimea 

// ex1
// Reverse and print the following array 

// declare the aray 

// declare the aray 

using System.CodeDom.Compiler;
using System.Text;

int[] array = { 1, 2, 3, 4, 5 };


static void PrintReverseArray1(int[] array) // ce e in paranteze e ce parametri accepta metoda mea (tipul si metoda parametrului)
{
    int arrayLenght = array.Length;
    int[] reversedArray = new int[arrayLenght];
    for (int i=0; 1<arrayLenght; i++)
    {
        reversedArray[i] = array[arrayLenght-i-1];
        Console.WriteLine(reversedArray[i]);
    }
}

static void PrintReserveArray2(int[] array)
{
    int[] reversedArray = new int[array.Length];

    for (int i= array.Length -1; i>=0; i--)
    {
        reversedArray[array.Length-i-1] = array[i]; 
    }
    for (int index=0; index<reversedArray.Length; index++)
    {
        Console.Write(reversedArray[index]);
    }


}
PrintReserveArray2(array);
PrintReverseArray1(array);

// metoda 

static void ReadAndPrintworkDays()
{
    // first task for the leght of the array 
    Console.WriteLine("Please type the lenght of the array");
    int length = int.Parse(Console.ReadLine());

    // next ask for the elements of the array
    Console.WriteLine("Please type the elements of the array");

    string[] workDays = new string[length];
    for (int i=0; i<length; i++)
    {
        workDays[i] = Console.ReadLine();

    }
    StringBuilder workDaysList = new StringBuilder();

    for (int index = 0; index<workDays.Length; index++)
    {
        workDaysList.Append(workDays[index]).Append(", ");
    }
    Console.WriteLine(workDaysList.ToString());
}

// CLONE VS COPY 

int[] copyArray = new int[5];
// copies the referencies 
copyArray = (int[])array.Clone();
copyArray[0] = 250;
foreach (int i in array)
{
    Console.Write(i);
}

// Multidimensional arrays

// Cel mai des intalnite array-uri multidimensionale sunt matricile (matrix)

// reading and printing matrices 

static void ReadMatrix()
{
    Console.WriteLine("Set the rows length: ");
    int rows = int.Parse(Console.ReadLine());
    Console.WriteLine("Set the columns lenght ");
    int colomns = int.Parse(Console.ReadLine());

    // define the matrix 

    int[,] matrix = new int[rows, colomns];
    // virgula ne spune ce dimensiune are arrayul nostru 

    for (int row =0; row < rows; row++)
    {
        for (int col = 0; col < colomns; col++)
        {
            matrix[row, col] = int.Parse(Console.ReadLine()); 
        }
    }
}
// jagged arrays - array dar cu coloane - dimensiuni diferite
//notatie de doua paranteze patrate 


// Array Class
//get the index of the weekend days

string[] days = { "luni", "marti", "miercuri", "duminica" };
int miercuri = Array.IndexOf(days, "miercuri");
Console.WriteLine(miercuri);
