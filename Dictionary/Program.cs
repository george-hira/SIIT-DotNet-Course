
// sa zicem ca am vrea sa avem notele studentilor 
// ne gandim ca la o matrice dar folosim dictionary


// keep the student grades in a dictionary

// declare a variabile 
Dictionary<string, double> studentGrades = new Dictionary<string, double>();


// populate the dictionary 
studentGrades.Add("Vasile", 9.5);
studentGrades.Add("Maria", 7.25);
studentGrades.Add("Ion", 5.5);
studentGrades.Add("Greta", 9.0);
// aceasta a fost o adaugare explicita 

foreach (var pair in studentGrades)
{
    Console.WriteLine($"{pair.Key} {pair.Value}");
}

Console.WriteLine();
Console.WriteLine("Print only the keys");

foreach(var key in studentGrades.Keys)
{
    Console.WriteLine(key);
}

// check if Vasile exists 

if (studentGrades.ContainsKey("Vasile"))
{
    studentGrades["Vasile"] = 8;

   
    
}

// remove an item 
studentGrades.Remove("Vasile");

// v2.
double tempValue = 0;
bool vasileExists = studentGrades.TryGetValue("Vasile", out tempValue);

Console.WriteLine("Is Vasile in dictionary? " + vasileExists);


// keys in dict are unique; cannot add the same key twice;
// think at real dictionary;
// studentGrades.Add("Vasile" , 5);

Console.WriteLine();

Dictionary<string, int> myGrades = new Dictionary<string, int>()
{
    { "Math", 9 },
    { "English", 7 }
};

//// 
// Sorted Dictionary
//// 
///

IDictionary<string, List<int>> complexDict = new Dictionary<string, List<int>>();

List <int> ints1 = new List <int> {1, 2, 3, 4, 5 };
complexDict.Add("one", ints1);

List<int> ints2 = new List<int> { 6, 7, 8 };
complexDict.Add("two", ints2);

List<int> ints3 = new List<int> { 9, 10, 11, 12 };
complexDict.Add("three", ints3);


ISet <int> numbers = new SortedSet<int>();
numbers.Add(1);
numbers.Add(2);

numbers.Add(5);
numbers.Add(9);

Console.WriteLine();

