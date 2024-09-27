Console.WriteLine("Tell me your Country and Aga and i will tell you if you can buy");
Console.WriteLine("Enter your Country");
string RecievedCountry = Console.ReadLine();
Console.WriteLine("Enter your Age");
int RecievedAge = int.Parse(Console.ReadLine());

if (RecievedCountry == "USA")
{
    if (RecievedAge >= 21)
    {
        Console.WriteLine("Bying Allowed");
    }
    else
    {
        Console.WriteLine("Bying Forbidden");
    }
}
else
{
    if (RecievedAge >= 18)
    {
        Console.WriteLine("Bying Allowed");
    }
    else
    {
        Console.WriteLine("Bying Forbidden");
    }
}