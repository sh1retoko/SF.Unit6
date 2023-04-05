using System;
using System.Reflection;

// Задание 6.6.2

// Добавьте в класс User из примера выше свойства для логина и почты:

// Поле логина должно быть не менее 3 символов длиной.
// Поле почты должно содержать знак @.

namespace Task6_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.Write("Cколько вам лет?: ");
            user.Age = int.Parse(Console.ReadLine());
            Console.WriteLine(user.Age);

            Console.Write("\nНапишите ваш логин: ");
            user.Login = Console.ReadLine();
            Console.WriteLine(user.Login);
         
            Console.Write($"\nНапишите вашу почту: ");
            user.Maill = Console.ReadLine();
            Console.WriteLine(user.Maill);
        }
    }
    class User
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть длиной от 3 символов");
                }
                else
                {
                    login = value;
                }
            }
        }

        private string maill;
        public string Maill
        {
            get
            {
                return maill;
            }
            set
            {
                if (!value.Contains("@"))
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    maill = value;
                }
            }
        }
    }
}
