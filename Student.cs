
namespace NewAssignment1
{
   public class Student
   {
        private int age;
        public string Name;

        private const int MIN_AGE = 18;
        private const int MAX_AGE = 99;

        private int Age
        {
            get { return age;}
            set { if (age >= MIN_AGE && MAX_AGE <= age) 
                {
                    age = value ;
                }
                else
                {
                    Console.WriteLine("Age must be between MIN_AGE and MAX_AGE!");
                }
                

            }
        }

        public int? Mark { get; set; }

        public Student(int age, string name)
        {
            Console.WriteLine("New Student created!");
        }

        public dynamic Info
        {

            get { return $"{Name}, Age: {Age}"; }
        }





   }
}
