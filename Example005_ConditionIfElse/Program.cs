Console.Write("Enter the user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "Tom")
{
    Console.WriteLine("Congratulation, this is Tom");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}