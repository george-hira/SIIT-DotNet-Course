
Console.WriteLine($"the result is : {Add()}");  



static int Add ()
{
    int a = 0;
    int b = 0;

    bool isAvalid = false;
    bool isBvalid = false;

    try
    {
        do
        {


            a = int.Parse(Console.ReadLine());
            isAvalid = true;

           
        } while( isAvalid );
        do
        {
            b = int.Parse(Console.ReadLine());
            isBvalid = true;
        }while ( isBvalid );

    }
    catch ( FormatException ex)
    {
        Console.WriteLine($"Pls enter a valid integer number. {ex}");
    }
    return a +b;
}

static void PrintText()
{
    throw new PrintingException("Unable to print the message");

}