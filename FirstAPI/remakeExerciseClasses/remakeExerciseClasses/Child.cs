
namespace remakeExerciseClasses
{
    internal class Child : Person
    {
        public Child(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }

       protected internal  int Age 
       { 

       get
       {
                return this.Age;
       }

       set
       {
               if ( value >15) 
                
               {
                    throw new ArgumentException("Children should not be able to have age more than 15!");
               }
               else
               {
                    this.Age = value;   
               }
                
       } 
        
       }

        
    }
}
