using System;

// Задание 6.5.2

// Опишите классы C# для следующих геометрических объектов: треугольник, круг, квадрат.

// В классах нужно объявить поля для длин сторон (радиус) и методы для получения площади и периметра (длины окружности) без их реализации и без конструкторов.

namespace Task6_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            trialge trialgeSquare = new trialge();
            trialgeSquare.Square();
            trialge trialgePerimeter = new trialge();
            trialgePerimeter.Perimeter();

            circle circleSquare = new circle();
            circleSquare.Square();
            circle circleLength = new circle();
            circleLength.Length();

            square squareSquare = new square();
            squareSquare.Square();
            square squarePerimeter = new square();
            squarePerimeter.Perimeter();
        }
    }

    class trialge
    {
        public bool ChecNum(string number, out double corrnumber)
        {
            if (double.TryParse(number, out double intNumber))
            {
                if (intNumber > 0)
                {
                    corrnumber = intNumber;
                    return false;
                }
            }

            corrnumber = 0;
            return true;
        }

        public double Square()
        {
            Console.WriteLine("Найти площадь треугольника");

            var side = new string[3];
            var sideNum = new double[3];

            for (int i = 0; i < side.Length; i++)
            {
                do
                {
                    Console.Write(i + 1 + ") Сторона: ");
                    side[i] = Console.ReadLine();

                } while (ChecNum(side[i], out sideNum[i]));
            }

            double Perimeter = (sideNum[0] + sideNum[1] + sideNum[2]) / 2;
            double Square = Math.Sqrt(Perimeter * (Perimeter - sideNum[0]) * (Perimeter - sideNum[1]) * (Perimeter - sideNum[2]));

            Console.WriteLine($"Площадь треугольника: {Square}");
            return Square;
        }

        public double Perimeter()
        {
            Console.WriteLine("\nНайти перемитер треугольника");

            var side = new string[3];
            var sideNum = new double[3];

            for (int i = 0; i < side.Length; i++)
            {
                do
                {
                    Console.Write(i + 1 + ") Сторона: ");
                    side[i] = Console.ReadLine();

                } while (ChecNum(side[i], out sideNum[i]));
            }

            double Perimeter = sideNum[0] + sideNum[1] + sideNum[2];

            Console.WriteLine($"Перимемтер треугольника: {Perimeter}");
            return Perimeter;
        }
    }
    class circle
    {
        public bool ChecNum(string number, out double corrnumber)
        {
            if (double.TryParse(number, out double intNumber))
            {
                if (intNumber > 0)
                {
                    corrnumber = intNumber;
                    return false;
                }
            }

            corrnumber = 0;
            return true;
        }

        public double Square()
        {
            Console.WriteLine("\nНайти площадь круга");

            string radius;
            double radiusNum;

            do
            {
                Console.Write("Введите радиус круга: ");
                radius = Console.ReadLine();

            } while (ChecNum(radius, out radiusNum));

            Console.WriteLine($"Площадь круга: {3.14 * radiusNum * radiusNum}");
            return radiusNum;
        }
        public double Length()
        {
            Console.WriteLine("\nНайти длинну окружности");

            string radius;
            double radiusNum;

            do
            {
                Console.Write("Введите радиус круга: ");
                radius = Console.ReadLine();

            } while (ChecNum(radius, out radiusNum));

            Console.WriteLine($"Длина окружности: {2 * 3.14 * radiusNum}");
            return radiusNum;
        }
    }
    class square
    {
        public bool ChecNum(string number, out double corrnumber)
        {
            if (double.TryParse(number, out double intNumber))
            {
                if (intNumber > 0)
                {
                    corrnumber = intNumber;
                    return false;
                }
            }

            corrnumber = 0;
            return true;
        }

        public double Square()
        {
            Console.WriteLine("\nНайти площадь квадрата");

            string side;
            double sideNum;

            do
            {
                Console.Write("Введите сторону квадрата: ");
                side = Console.ReadLine();

            } while (ChecNum(side, out sideNum));

            Console.WriteLine($"Площадь квадрата равна: {sideNum * sideNum}");
            return sideNum;
        }

        public double Perimeter()
        {
            Console.WriteLine("\nНайти периметр квадрата");

            string side;
            double sideNum;

            do
            {
                Console.Write("Введите сторону квадрата: ");
                side = Console.ReadLine();

            } while (ChecNum(side, out sideNum));

            Console.WriteLine($"Периметр квадрата: {sideNum * 4}");
            return sideNum;
        }
    }        
}
