// Scrieti o functie par_impar(n) care primeste ca parametru un numar intreg si returneaza un rezultat de tip string, care contine una dintre valorile 'par'/'impar',
// in functie de paritatea numarului.


using System.ComponentModel;

Console.WriteLine("Get a number");

    string numberTake = "";
    numberTake = Console.ReadLine();
    int numberTaken = int.Parse(numberTake);





Par_Impar(numberTaken);



int Par_Impar(int number1)
{
    if (number1 % 2 == 0)
    {
        Console.WriteLine("Numarul este par: " + number1);
    }
    else
    { Console.WriteLine("Numarul este impar: " + number1); }

    return number1;
}


//Scrieti o functie semn(n) care implementeaza functia semn din matematica, definita astfel:
//o functie care primeste ca parametru un numar si returneaza ca rezultat una din valorile: -1 daca numarul e negativ, +1 daca e pozitiv sau 0 daca e egal cu zero.

Sign(numberTaken);
int Sign(int numberTaken)
{
    switch (numberTaken)
    {
        case < 0:
            Console.WriteLine("-1");
            break;
        case > 0:
            Console.WriteLine("+1");
            break;
        default: Console.WriteLine("0");
            break;
        
    }
    return numberTaken;
}

//#Scrieti o functie fizzbuzz(n) care primeste ca parametru un numar intreg si afiseaza un text, bazat pe aceste reguli:

//#     daca numarul e divizibil cu 3, afiseaza 'fizz'
//#     daca numarul e divizibil cu 5, afiseaza 'buzz'
//#     daca numarul e divizibil si cu 3 si cu 5, afiseaza 'fizzbuzz'
//#     altfel afiseaza numarul initial


FizzBuzz(numberTaken);

int FizzBuzz(int numberTaken)
{
    if(numberTaken % 3 == 0 &&numberTaken % 5==0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (numberTaken % 3 == 0 && numberTaken % 5!=0)
    {
        Console.WriteLine("fizz");
    }
    else if (numberTaken % 5 == 0 && numberTaken % 3!=0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(numberTaken);
    }
    return numberTaken;
}


//# Scrieti o functie numita cifra_comuna(x,y) care primeste ca parametrii 2 numere intregi si returneaza valoarea boolean True
//doar in cazul in care ambele numere au exact 2 cifre (sunt in intervalul 10..99)
//si au macar o cifra comuna, altfel returneaza valoarea False.

Console.WriteLine("Get a second number pls:");

string secondNumberTaken = Console.ReadLine();
int secondNumberInt = int.Parse(secondNumberTaken);

CommonFigure(numberTaken, secondNumberInt);

bool CommonFigure(int a, int b)
{
    string aConverted = a.ToString();
    string bConverted = b.ToString();

    int lengthA = aConverted.Length;
    int lengthB = bConverted.Length;

    if (lengthA == 2 && lengthB == 2)
    {
        foreach(char digit in aConverted)
        {
            if (bConverted.Contains(digit))
            {
                Console.WriteLine("true");
                return true;
            }
   
        } 
    }
    Console.WriteLine("false");
    return false;

}