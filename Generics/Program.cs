using Generics;

public class Program
{

    public static void Main()
    {
        CustomList<int> list1 = new CustomList<int>();
        list1.Add(1);
        
        CustomList<string> list2 = new CustomList<string>();

        list2.Add("this is a text");

        CustomList<Person> list3 = new CustomList<Person>();
        list3.Add(new Person());

        // using generic methods
        CustomOperations op = new CustomOperations();
        op.Swap<string>("Hell", "summer");
        op.Swap<int>(1, 2);




        Dictionary <int, List<int>> x= new Dictionary<int, List<int>>();

        



    }


}

public class Person
{
    public string Name { get; set; }

}