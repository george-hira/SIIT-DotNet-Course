// You have some text that contains your email address.
// And you want to hide that.
// You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain.
// Assume your email address will always be in format [username]@[domain].
// You need to replace the username with asterisks of equal number of letters and keep the domain unchanged.
// You will get as input the email address you need to obfuscate
//Input
//awesome@dotnet.com

//Output
// *******@dotnet.

// 1st version as simple as possible


Console.WriteLine("Enter your adress: ");

string emailAdressInput= Console.ReadLine();

string obfuscatedEmail = ObfuscateEmail(emailAdressInput);
Console.WriteLine(obfuscatedEmail);
static string ObfuscateEmail(string emailAdressInput)
{
    int atIndex = emailAdressInput.IndexOf('@');
    string username = emailAdressInput.Substring(0, atIndex);
    string domain = emailAdressInput.Substring(atIndex);
    string obfuscatedUsername = new string('*', username.Length);
    string obfuscatedEmail = obfuscatedUsername + domain;
    return obfuscatedEmail;
}

// 2nd version with iteration

static string CensorEmail(string emailAddress)
{
    string[] emailApart = emailAddress.Split('@');
    string username = emailApart[0];
    string domain = emailApart[1];
    string obfuscatedUsername = string.Empty;
    foreach (char c in username)
    {
        obfuscatedUsername += "*";
    }
    string censoredEmail = obfuscatedUsername + "@" + domain;
    return censoredEmail;
}
Console.WriteLine("Enter email address to censore: ");
string emailAddress = Console.ReadLine();
if (emailAddress.Contains('@'))
{
    string censoredEmail = CensorEmail(emailAddress);
    Console.WriteLine(censoredEmail);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Successful! ");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid email! ");
    Console.ResetColor();
}


Console.ReadKey();




