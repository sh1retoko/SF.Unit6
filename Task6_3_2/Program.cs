using System;

// Задание 6.3.2

// Для класса Bus реализуйте метод PrintStatus, который будет сообщать о количестве пассажиров в автобусе, если они есть. Или сообщать, что автобус пуст.

namespace Task6_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus Bus = new Bus();
            Bus.PrintStatus();
        }
    }
    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine($"В автобусе {0} пассажиров", Load.HasValue);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }
}
