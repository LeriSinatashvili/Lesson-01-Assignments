Console.WriteLine("Put Number and i will tell your Grade");
int RecievedNumber = int.Parse(Console.ReadLine());

if (RecievedNumber >= 90)
{
    Console.WriteLine("You got A");
}
else if (RecievedNumber >= 80 && RecievedNumber <= 89)
{
    Console.WriteLine("You got B");
}
else if (RecievedNumber >= 70 && RecievedNumber <= 79)
{
    Console.WriteLine("You got C");
}
else if (RecievedNumber >= 60 && RecievedNumber <= 69)
{
    Console.WriteLine("You got D");
}
else
{
    Console.WriteLine("Your got F");
}