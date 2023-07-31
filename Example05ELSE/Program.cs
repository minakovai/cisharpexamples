Console.WriteLine("Please input user name ");
string username = Console.ReadLine();
if (username.ToLower() == "mary")
{
    Console.WriteLine ("Yehoo! This is Mary!");
}
else
{
    Console.Write ("Hello, ");
    Console.WriteLine (username);
}