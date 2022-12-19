Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "яйка"|| username.ToLower() == "женя" || username.ToLower() == "евгений" || username.ToLower() == "яйцо"  )
{
Console.WriteLine("Женя, который Яйцо? Брал?");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}