using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClassesBA
{
    internal class Animal
    {
        // creez niste obiecte care sunt animale 
        // atribute pe care animalele le au

        public int varsta; // are valoarea 12
        public readonly string name;
        

       
        public int Varsta { set { value = varsta; } }
        // nu lasam utilizatorul sa ne foloseasca varsta 

        public Animal (int varsta) // acesta este un constructor
        {
            this.varsta = varsta; // varsta = inputul introdus de utilizator 
                                    // ca param cand creaza un obiect 
        }

        public int Varsta
        {

            get 
            { 
                return varsta; 
            }
            set
            {
                value = varsta;
            }
            
        }

        public Animal(string name)
        {
            this.name = name;   
        }
    }
}
