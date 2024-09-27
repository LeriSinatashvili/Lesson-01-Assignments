Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
Console.WriteLine(DateTime.Now.Hour);

if (DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 12)
{
    Console.WriteLine("Good Morning");
}

if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 17)
{
    Console.WriteLine("Good Afternoon");
}

if (DateTime.Now.Hour >= 17 && DateTime.Now.Hour < 21)
{
    Console.WriteLine("Good Evening");
}

if (DateTime.Now.Hour >= 21)
{
    Console.WriteLine("Good Night");
}