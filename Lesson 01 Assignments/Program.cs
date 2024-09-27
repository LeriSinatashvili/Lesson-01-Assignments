Console.WriteLine("Put Number and i will tell you if its Even or Odd");
int RecievedNumber = int.Parse(Console.ReadLine());

if (RecievedNumber % 2 == 0)
{
    Console.WriteLine("Your Number is Even");
}
else
{
    Console.WriteLine("Your Number is Odd");
}