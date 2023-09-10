
namespace NewAssignment1
{
   public class Student
   {
        private int age;
        public string Name;

        private static int MIN_AGE = 18;
        private static int MAX_AGE = 99;

        private int Age
        {
            get
            {
                return age;
            }
            set 
            { if (value < MIN_AGE && MAX_AGE > age) 
                {
                    Console.WriteLine("Invalid age! ");
                }
                else
                {
                    age = value;
                }
                

            }
        }

        public int? Mark { get; set; }

        //private static int AverageMark(int Mark)
        //{
        //    if (Mark != null)
        //    {

        //    }

        //}

        public Student( string name, int age)
        {
            this.Name= name;
            Age= age;
            Console.WriteLine("New Student created!");
        }

        public dynamic Info
        {

            get
            {
                if (Age < MAX_AGE && age > MIN_AGE)
                {
                    return Name + Convert.ToString(age);
                }
                return Name;
            }
        }





   }
}
