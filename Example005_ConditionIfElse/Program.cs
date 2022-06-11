Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "костя")
{
    Console.WriteLine("Ура это же КОСТЯ ! ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}