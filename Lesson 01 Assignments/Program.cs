Console.WriteLine("Tell me your Age and i will tell you if you are allowed to vote or not");
int RecievedNumber = int.Parse(Console.ReadLine());

if (RecievedNumber >= 18)
{
    Console.WriteLine("You can Vote");
}
else
{
    Console.WriteLine("Your Can Not Vote");
}