//EX10:  Write program that outputs a triangle made of stars with variable size, depending on an input parameter.
// Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number.
// The output is a series of lines printed on the console, forming a triangle of variable size.

// concatenare sau stringbuilder???

public class Program
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 3, 5, 2, 3, 3, 1 };
        int element = 3;
        Console.WriteLine(GetOccurrencies(array, element));
    }

    public static int GetOccurrencies(int[] array, int element)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num == element)
            {
                count++;
            }
        }
        return count;
    }


    // Write a program to find the sum of all elements of the array


    public static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }
}