Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "юрий")
{
Console.WriteLine("Тот самый Юрий??? Ураааа!!!!!");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}