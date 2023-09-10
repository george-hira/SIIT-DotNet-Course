
namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args) 
        {
            Car myCar = new Car(); // creating the new instance . Asta e ceea ce inseamna crearea unei instante
            // the "new" keyword is what we will consider to be the factory
            // builds the new car and puts it into memory

            myCar.Make = "Young Car"; // this are setting the properties
            myCar.Model = "Honda Civic Type R"; // properties

            myCar.Year = 2012;
            myCar.Color = "White";

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make,             
                myCar.Model,              // getting the properties to set them out
                myCar.Year ,
                myCar.Color);

          decimal value =  DetermineMarketValue(myCar);
            Console.WriteLine("{0:C}", value);

            Console.ReadLine();
        }
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;

            // Someday I might look up the car 
            // online webservices to get more 
            // accurate value.

            return carValue;

        }
    }

    class Car
    {
        public string Make{get; set;} // this are properties
        public string Model { get; set;} // this are properties

        public int Year { get; set;}
        public string Color { get; set;}

        public decimal DetermineMarketValue() 
        {
            if (Year > 1990)

                    carValue = 10000;

             else

        }
    }


}