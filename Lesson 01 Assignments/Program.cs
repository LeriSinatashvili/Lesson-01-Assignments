Console.WriteLine("Put 3 Numbers and i will tell you which is Highest");
Console.WriteLine("Enter your First Number");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your Second Number");
int SecondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your Third Number");
int ThirdNumber = int.Parse(Console.ReadLine());

if (FirstNumber > SecondNumber)
{
    if (FirstNumber > ThirdNumber)
    {
        Console.WriteLine("Highest Number is First One");
    }
    else
    {
        Console.WriteLine("Highest Number is Third One");
    }
}
else
{
    if (SecondNumber > ThirdNumber)
    {
        Console.WriteLine("Highest Number is Second One");
    }
    else
    {
        Console.WriteLine("Highest Number is Third One");
    }
}
