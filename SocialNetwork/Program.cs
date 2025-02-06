using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;

namespace SocialNetwork
{
    internal class Program
    {
        public static UserService userService = new UserService();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Добро пожаловать в социальную сеть.");
                Console.WriteLine("Для регистрации пользователя введите имя пользователя: ");
                string firsName = Console.ReadLine();

                Console.WriteLine("Фамилия: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("Пароль: ");
                string password = Console.ReadLine();

                Console.WriteLine("Почтовый адрес: ");
                string email = Console.ReadLine();

                UserRegistrationData userRegistrationData = new UserRegistrationData()
                {
                    FirstName = firsName,
                    LastName = lastName,
                    Password = password,
                    Email = email,
                };

                try
                {
                    userService.Register(userRegistrationData);
                    Console.WriteLine("Регистрация произошла успешно!");
                }

                catch (ArgumentNullException)
                {
                    Console.WriteLine("Введите корректное значениею");
                }

                catch (Exception)
                {
                    Console.WriteLine("Произошла ошибка при регистрации.");
                }

                Console.ReadLine();
            } 
        }
    }
}
