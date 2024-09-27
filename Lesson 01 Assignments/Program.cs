Console.WriteLine("Enter total cost");
decimal RecievedNumber = decimal.Parse(Console.ReadLine());

if (RecievedNumber < 100)
{
    Console.WriteLine("No discount, you pay");
    Console.WriteLine(RecievedNumber);
}
else if (RecievedNumber < 500)
{
    Console.WriteLine("You got 10% discount, you pay");
    Console.WriteLine(RecievedNumber * 0.9m);
}
else
{
    Console.WriteLine("You got 20% discount, you pay");
    Console.WriteLine(RecievedNumber * 0.8m);
}