Console.WriteLine("Put Number and i will tell you if its Positive, Negative or Zero");
int RecievedNumber = int.Parse(Console.ReadLine());

if (RecievedNumber > 0)
{
    Console.WriteLine("Your Number is Positive");
}
else if (RecievedNumber < 0)
{
    Console.WriteLine("Your Number is Negative");
}
else
{
    Console.WriteLine("Your Number is Zero");
}
