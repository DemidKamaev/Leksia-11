// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Даша")
{
    Console.WriteLine("УРа, это же Даша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}