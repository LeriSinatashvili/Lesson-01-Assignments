Console.WriteLine("This is simple calculator");
Console.WriteLine("Enter first number");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter operation you want");
string Operation = Console.ReadLine();
Console.WriteLine("Enter second number");
int SecondNumber = int.Parse(Console.ReadLine());

if (Operation == "+")
{
    Console.WriteLine("Result is");
    Console.WriteLine(FirstNumber + SecondNumber);
}

if (Operation == "-")
{
    Console.WriteLine("Result is");
    Console.WriteLine(FirstNumber - SecondNumber);
}

if (Operation == "*")
{
    Console.WriteLine("Result is");
    Console.WriteLine(FirstNumber * SecondNumber);
}

if (Operation == "/")
{
    Console.WriteLine("Result is");
    Console.WriteLine(FirstNumber / SecondNumber);
}
