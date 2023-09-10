using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AboutClasses
{
    internal class FootbalPlayer
    {
        // definesc clasa in exteriorul clasei program


        // fields of the class 

        private string name;
        private string country;
        private double rating;
        private int age;

        // pot exista clase in acelasi fisier dar best practice clasele sa stea in propriul ei fisier 
        // proprietati cum definesc 
        // constructors // ctor + tab  // acestia sunt la inceputul clasei
        // parameters constructor 
        public FootbalPlayer()
        {
            // creates the instance of the class 
        }
        public string Name
        {
            get { return name; } // automatic proprieties 
            set { name = value; }
        }
        public FootbalPlayer(string name)
        {
            this.name= name;
        }
        // proprietatea se scrie cu litere mare - pascal case (incep cu o litera mare fiecare cuvant)
        public string Country { get; set; }
        public double Rating { get; set; }
        // acestea sunt proprietatile clasei

        public int Age
        {
            get{return age;}
            set
            {
                age = value > 0 ? value : 0;
            }
        }
    }// internal inseamna ca l poti folosi doar din cadrul acestui proiect
}
