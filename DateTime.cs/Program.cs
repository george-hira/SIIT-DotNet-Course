﻿/* Model the Rabbit class knowing that:
a rabbit can have Blue, Red or Black eyes
a rabbit's fur can be white, brown, black or grey
it has a gender
has a birth date, and based on that you should be able to see how old the rabbit is
we also know that a rabbit is a mammal that moves, sleeps and eats certain foods*/

public class Rabit // define a class 

{
    public string Eyes { get; set; }
    public string Fur { get; set; } 

    public char Gender { get; set; }

    public DateTime DateOfBirth { get; set; }

    public int Age { get; set; }    

    public void Sleeps()
    {
        Console.WriteLine("I'm a rabbit and I sleep");
    }


}




