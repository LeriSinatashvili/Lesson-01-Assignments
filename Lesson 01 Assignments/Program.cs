Console.WriteLine("Tell me your age and annual income and i will tell you if you can have loan");
Console.WriteLine("Enter your Age");
int RecievedAge = int.Parse(Console.ReadLine());

if (RecievedAge >= 18)
{
    Console.WriteLine("Enter your income");
    decimal RecievedIncome = decimal.Parse(Console.ReadLine());

    if (RecievedIncome >= 25000)
    {
        Console.WriteLine("You can have loan");
    }
    else
    {
        Console.WriteLine("You cant have loan but can take part in it");
    }
}
else
{
    Console.WriteLine("You cant have load");
}