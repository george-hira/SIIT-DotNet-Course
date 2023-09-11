
//You are asked to model an application for storing data about people. 
//You should be able to have a person and a child. 
//The child is derived of the person. Your task is to model the application. The only constraints are:

//    People should not be able to have negative age
//    Children should not be able to have age more than 15.

//• Person – represents the base class by which all others are implemented 
//• Child - represents a class which is derived by the Person. 

// Validate each member by throwing an ArgumentException.


namespace remakeExerciseClasses
{
    internal class Person
    {

        protected int _age;
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        protected internal int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("People should not be able to have negative age");
                }
                else 
                { 
                    _age=value; 
                }
            }
        }

        public Person(string firstName, string lastName, int age) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }



        

    }
}
