Console.WriteLine("Put Year and i will tell your Something About It");
int RecievedNumber = int.Parse(Console.ReadLine());

if (RecievedNumber % 4 == 0 && RecievedNumber % 100 != 0 && RecievedNumber % 400 != 0)
{
    Console.WriteLine("Something about your Year");
}
else
{
    Console.WriteLine("Nothing about your Year");
}