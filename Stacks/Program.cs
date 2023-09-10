public class Program
{
    public static void Main()
    {
       Stack<string> cities = new Stack<string>();

        // add in stack 
        cities.Push("1. Iasi");
        cities.Push("2. Cluj");
        cities.Push("3. Bucuresti");
        cities.Push("4. Oradea");

        string lastElement = cities.Peek();

        Console.WriteLine("Last elements is: " + lastElement);

        while(cities.Count > 0)
        {
            var currentCity = cities.Pop();
            Console.WriteLine(currentCity);
        }

    }
}

