Console.WriteLine("Hello, insert Your E-Mail And Get Started");
string email = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Insert Your Password");
string passwd = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Insert Your Name");
string name = Console.ReadLine();

Console.WriteLine("\n");

switch (email)
{
    case "":
        Console.WriteLine("the email does not correspond to any account, check the email placed, thanks");
        Console.WriteLine("Press Key <ENTER> To Exit");
        var keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.Enter)
        {
            Environment.Exit(0);
        }
        break;

    default:
        Console.WriteLine("Thanks, You As Acces In My Application.");
        break;
}

Console.WriteLine("\n");

Console.WriteLine("You Email Is Correct? " + "< " + email + " >" + " Yes Is Correct, Press <ENTER>");
while (Console.ReadKey().Key != ConsoleKey.Enter) { }
Console.WriteLine("\n");

Console.WriteLine("You PassWord Is Correct? " + "< " + passwd + " >" + " Yes Is Correct Press <ENTER>");
while (Console.ReadKey().Key != ConsoleKey.Enter) { }
Console.WriteLine("\n");

Console.WriteLine("Ok, yes all data is correct, continue with the application. Press Key <ENTER>");
while (Console.ReadKey().Key != ConsoleKey.Enter) { }
Console.WriteLine("\n");

Console.WriteLine("Welcome " + name + ", This is FasttWebb, One Application Of < Computers And Programming In C# >");
