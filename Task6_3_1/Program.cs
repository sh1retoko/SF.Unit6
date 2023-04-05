using System;

// Задание 6.3.1

// Напишите такой код, который бы при типе компании, равному типу "Банк", и городе "Санкт-Петербург" выводил в консоль сообщение "У банка ??? есть отделение в Санкт-Петербурге", где вместо "???" выводилось бы название компании.

// Если у компании нет названия, вместо него должно быть "Неизвестная компания".

namespace Task6_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var department = new Department();

            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine($"У банка {department} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
        }

        static Department GetCurrentDepartment()
        {
            Department depart = new Department();
            depart.Company.Type = "Банк";
            depart.Company.Name = "Alfa";
            depart.City.Name = "Санкт-Петербург";

            return depart;
        }
    }

    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company = new Company();
        public City City = new City();
    }

    class City
    {
        public string Name;
    }
}
