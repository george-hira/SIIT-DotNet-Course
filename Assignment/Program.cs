namespace Assignment2
{


    // Create a class Student 
    class Student
    {
        // two fields: age and name
        public string name;
        public int age;

        // a constructor with age and name parameters
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //  a constant field named MIN_AGE equal to 18
        // a constant field named MAX_AGE equal to 99

        public const int MIN_AGE = 18;
        public const int MAX_AGE = 99;

        //  a full property named Age (validate for minimum input  MIN_AGE and maximum input MAX_AGE)
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < MIN_AGE || value > MAX_AGE)
                {
                        Console.WriteLine($"Age must be between{MIN_AGE} and {MAX_AGE}");
                   
                }
                else age = value;
            }
        }

        //  a nullable automatic property named Mark

        public int? Mark { get; set; }
        public string Name { get; set; }

        public Student(string name, int? mark)
        {
            Name = name;
            Mark = mark;
        }

        // a readonly dynamic property named Info, combining name and age in one string
        public string Info => ($"Age must be between {MIN_AGE} and {MAX_AGE}.");


            public void PrintInfo()
        {
            Console.WriteLine($"{Info}");
        }


  }

    
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("George", 100);
            Student student2 = new Student("Cosmin", null);
        }
        Student Student1 = new Student("Alecu", 24);
    }




    

  

}
