

using NewAssignment1;

Console.WriteLine("Enter student's name: ");
string name = Console.ReadLine();


Console.WriteLine("Enter student's age: ");
string ageUnconverted = Console.ReadLine();
int age = Convert.ToInt32(ageUnconverted);


Student student1 = new Student("Mada", 26);

Console.WriteLine(student1.Info);

