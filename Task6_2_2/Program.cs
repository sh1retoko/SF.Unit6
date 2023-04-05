using System;

// Задание 6.2.2

// Добавьте в класс Pen, указанный ниже, 2 конструктора:

// Без параметров, когда поля color и cost заполняются значениями Черный и 100.
// C 2 параметрами: penColor и penCost.

namespace Task6_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Черный";
            cost = 100;
        }
        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }
}
