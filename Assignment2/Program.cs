using System;

class Student
{
    // Fields
    private int age;
    private string name;

    // Constants
    private const int MIN_AGE = 18;
    private const int MAX_AGE = 99;

    // Properties
    public int Age
    {
        get => age;
        set
        {
            if (value >= MIN_AGE && value <= MAX_AGE)
                age = value;
            else
                throw new ArgumentException($"Age should be between {MIN_AGE} and {MAX_AGE}.");
        }
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value), "Name cannot be null.");
    }

    public int? Mark { get; set; }

    // Constructor
    public Student(int age, string name)
    {
        Age = age;
        Name = name;
    }

    // Read student's age and name from the console
    public static Student ReadStudentFromConsole()
    {
        Console.Write("Enter student's age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter student's name: ");
        string name = Console.ReadLine();

        return new Student(age, name);
    }

    // Info property
    public string Info => $"{Name}, Age: {Age}";

    // Bonus: Read marks for multiple students and calculate average mark
    public static void Main(string[] args)
    {
        const int numberOfStudents = 3; // Change this to the desired number of students
        double sumOfMarks = 0;
        int studentsWithMarks = 0;

        Student[] students = new Student[numberOfStudents];
        for (int i = 0; i < numberOfStudents; i++)
        {
            students[i] = ReadStudentFromConsole();

            // Read mark from the console
            Console.Write($"Enter mark for {students[i].Name}: ");
            int? mark = int.TryParse(Console.ReadLine(), out int tempMark) ? tempMark : (int?)null;
            students[i].Mark = mark;

            if (mark.HasValue)
            {
                sumOfMarks += mark.Value;
                studentsWithMarks++;
            }
        }

        Console.WriteLine("\nStudent Information:");
        foreach (var student in students)
        {
            Console.WriteLine(student.Info + (student.Mark.HasValue ? $", Mark: {student.Mark}" : ""));
        }

        double averageMark = studentsWithMarks > 0 ? sumOfMarks / studentsWithMarks : 0;
        Console.WriteLine($"\nAverage Mark: {averageMark:F2}");
    }
}

