using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningProperties
{ // create a property for volume which surronds
    class Box
    {
        // member variable 
        private int length = 3;
        private int height;
        private int width;
        private int volume;

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width ;
            }      
       
        }

        // linia de cod de mai jos este acelasi lucru cu linia de mai jos (linia20)
        public int Width{ get; set; }

       /* public int Width
        {
            get
            {
                return width;
            }

            set
            { 
                if(value < 0)
                {
                    width = -value;
                }
                else
                {
                    width = value;
                }
                
            }
        }*/
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                // we cand adjust it 
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }

            }

        }



        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("The length should be more than 0! ");
            }
            this.length = length;
        }
        // this is an alternative but if we need the field length we cannot acces it 

        public int GetLength()
        {
            return this.length;
        }


           public void DisplayInfo()
           {
               Console.WriteLine("Length is {0}, and height is {1}, and width is {2} so volume is {3} ", 
                   length, height, Width, volume= length*height*Width);
           }

        

    }
}
