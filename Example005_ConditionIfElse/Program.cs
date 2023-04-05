Console.WriteLine("Enter User name:");
string? username = Console.ReadLine();
if (username !=null) {
if (username.ToLower() == "masha")
{
    Console.WriteLine("Hi! It's Masha!");
}
else
{
    Console.Write("Hi,");
    Console.WriteLine(username);
}
}