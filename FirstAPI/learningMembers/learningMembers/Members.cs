using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace learningMembers
{
    class Members
    {

        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary; 

        // member - public field 
        public int age;

        // member property - exposes jobTitle safely - properties start with capital Letter

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        // public member - Method - can be called from the other classes  

        public void Introduce(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old.",memberName, jobTitle, age);
            }

        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // member constructor 

        public Members()
        {
            age = 30;
            memberName = "George";
            salary = 10000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor 
        //~Members()
        //{
        //    // cleanup statements 
        //    Console.WriteLine("Deconstruction of Members Object");
        //    Debug.Write("Destruction!");
        //}
    }
}
