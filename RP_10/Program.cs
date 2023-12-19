using System.Drawing;

namespace PR_10
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                var userInSystem = Auto();
                Console.Clear();
                if (userInSystem.role == "Administrator")
                {
                    var administrator = new Administrator();
                    administrator.ADMenu(userInSystem);
                }
            }
        }
        static User Auto()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password = string.Empty;
                ConsoleKeyInfo info;
                while (true)
                {
                    info = Console.ReadKey(true);
                    if (info.Key == ConsoleKey.Enter)
                        break;
                    password += info.KeyChar;
                    Console.Write('*');
                }
                Console.WriteLine();
                foreach (var user in SerealizationNDeserialization.GetData())
                {
                    if (user.login == login)
                        if (user.password == password)
                        {
                            var loggedUser = new User(user.id, login, password, user.role);
                            return loggedUser;
                        }
                }
                Console.WriteLine("Логин или пароль неверный");
            }
        }
    }
}
