using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClasses
{   
    // add 2 more member variable to Human, eyeColor and age;
    // adjust the constructor, so it requires all the four values to be used, when creating an object of Human;
    // create 2 objects of type Human 
    
     class Human
    {
        // member variables 

        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;


        // member method
        // create a public variable lastName of type string 
        // change the IntroductionMyself method, so it tells the whole name 
        // create 2 objects with full information about themself - firsName and lastName

        // default constructor 
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        // Parameterized Constructor 
        public Human(string firstName) /*parametrii pe care dorim sa ii avem de fiecare data cand cream un obiect al acestei clase*/
        {
            this.firstName = firstName;
            // global variable = is going to be;

        }

        // I made all of this constructors with different parameters because if we don't have al the data's this will help
        // and also we get datas from data bases. 

        public Human(string firstName, string lastName) /*parametrii pe care dorim sa ii avem de fiecare data cand cream un obiect al acestei clase*/
        {
            this.firstName = firstName;
            // global variable = is going to be;
            this.lastName = lastName;

        }
        public Human(string firstName, string lastName, string eyeColor) /*parametrii pe care dorim sa ii avem de fiecare data cand cream un obiect al acestei clase*/
        {
            this.firstName = firstName;
            // global variable = is going to be;
            this.lastName = lastName;
            this.eyeColor = eyeColor;

        }

        public Human(string firstName, string lastName, string eyeColor, int age) /*parametrii pe care dorim sa ii avem de fiecare data cand cream un obiect al acestei clase*/
        {
            this.firstName = firstName;
            // global variable = is going to be;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;

        }
        public void IntroduseMySelf()
        {
            if (age <= 14 && lastName != null && eyeColor != null && firstName != null)
                Console.WriteLine($"Hi, I'm {firstName} {lastName}." +
                    $"\n My eyes are {eyeColor}.");
            else if (age <= 14 && lastName != null && firstName != null)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}." +
                    $"\n And I'm {age} years old.");
            }
            else if ( lastName != null && firstName != null)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}.");
            }
            else if (firstName != null)
            {
                Console.WriteLine($"Hi, I'm {firstName} ");
            }

        }

        

         

     }
}
