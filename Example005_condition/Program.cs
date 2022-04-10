Console.Write("ВВедите имя пользователя: ");
string username = Console.ReadLine();

if(username == "Маша")
{
    Console.WriteLine("Ура, эт же Машка");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}