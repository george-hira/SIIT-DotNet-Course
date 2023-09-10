using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

public class Program
{
    // Write a program to find the sum of all elements of the array
    public static void Main()
    {
        // Example usage
        int[] myArray = { 1, 6, 3, 11, 5 };
        int sum = CalculateSum(myArray);
        Console.WriteLine("Sum of all elements: " + sum);
    }

    public static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

   // Write a program that reads the elements of an array of integer numbers, sorts the array and
   // then prints them back on the console.The numbers should be entered from the console on a single line,separated by a space.
   // Print the sorted array in the following format: “[element1, element2...elementN]”.
   // Condition: Do not use the built-in sorting method, you should write the logic yourself.Use the bubble sort
   // algorithm.

    public static int PrintSortedArray()
    {
        Console.WriteLine("Introduce the lenght of the array: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];

        Console.WriteLine("Type the numbers seppared by space");
        string input = Console.ReadLine();

        string[] splittedArray = input.Split(' ');
        int[] myarray = new int[splittedArray.Length];
        

        for (int i=0; i < splittedArray.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
           
        }
        return myarray;
    }
}

