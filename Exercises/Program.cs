// Write a program, which reads from the console N integers and prints them in reversed order.
// Use the Stack<int> class





// Write a program in that finds in a given array of integers (in the range [0…1000]) how many times each of them occurs.
// Example: array = { 3, 4, 4, 2, 3, 3, 4, 3, 2}
// 2-- > 2 times
// 3-- > 4 times
// 4-- > 3 times

int[] array = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

List <int> numbers = new List <int>();
List <int> occurences = new List <int>();

for (int i = 0; i<array.Length; i++)
{
    int value= array[i];

    if (!numbers.Contains(value))
    {
        numbers.Add(1);
    } 
    else
    {
        var index = numbers.IndexOf(value);
        occurences[index]++; 
    }

}

// print the result 
//foreach (int number in numbers)
//{
//    var index = numbers.IndexOf(number);
//    Console.WriteLine($"{number} ==> {occurences[number]} times");
//}

//for(int index = 0; index < numbers.Count;)
//{

//}

// make it works with array

// iteram prin array
// valoare nu exista in dictionar 
    // da-> add to dict (valoarea, 1)
    // nu-> update value in dict (valoarea, ++)

static void OccurencesWithDictionarry(int[] array)
{
    Dictionary<int, int> occurences = new Dictionary<int, int>();

    for(int i=0; i <array.Length; i++)
    {
        int key = array[i];

        if (!occurences.ContainsKey(key))
        {
            occurences.Add(key, 1);

        }
        else
        {
            // update value in the dict
            //occurences[key] = occurences[key]+1;
            //int dictionary;
            //occurences.TryGetValue(key, out dictionary);
            occurences[key]++;
        }
    }
    // Print the values 
    foreach(var pair in occurences)
    {
        Console.WriteLine(pair.Key);
    }

}
