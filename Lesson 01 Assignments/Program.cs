Console.WriteLine("Put Password to see if you have Access");
string RecievedPassword = Console.ReadLine();

string AccessablePassword = "secret123";

if (RecievedPassword == AccessablePassword)
{
    Console.WriteLine("Access Granted");
}
else
{
    Console.WriteLine("Access Forbidden");
}