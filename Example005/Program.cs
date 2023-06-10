Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{   
    Console.WriteLine("Ура, это же Maria");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}