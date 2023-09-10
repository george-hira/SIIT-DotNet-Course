using AboutClasses;

public static class Program
{
    public static void Main()
    {
       // string name1 = "Ronaldo";
       // string country1 = "Portugal";
       // double rating1 = 100;

       // string name2 = "Hagi";
       // string country2 = "Romania";
       // double rating2 = 100;

        FootbalPlayer player1 = new FootbalPlayer(); // inca nu am salvat dar momentan am creat o zona de memorie alocata pt acest obiect nou
        // aici este doar referinta in memoria dinamica pentru noul obiect 

        // un constructor are acelasi nume ca si clasa lui
        // acestia sunt la inceputul clasei
        // constructorul are si el nevoie de () doar ca e constructor fara parametri. 
        // cei cu parateze goale sunt contructori impliciti fara parametri 



        // dam valorile lui player1
        player1.Name = "Ronaldo";
        player1.Country = "Portugal";
        player1.Rating = 100;
        player1.Age = -87;
        // exista o modalitate mai faina de a da valori, numita constrructori 

        FootbalPlayer player2 = new FootbalPlayer("Hagi");

        Console.WriteLine(player1);
        Console.WriteLine($"{player1.Name} {player1.Country} {player1.Age}");
    }
}

// am nevoie sa ii spun de unde esti tu footbal player 

// 