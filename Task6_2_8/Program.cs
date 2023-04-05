using System;

// Задание 6.2.8

// Создайте класс Rectangle для представления прямоугольников удовлетворяющий следующим требованиям:

// Класс должен содержать целочисленные поля для сторон a и b.
// Класс должен содержать метод Square, возвращающий площадь прямоугольника (произведение сторон).
// Класс должен содержать 3 конструктора: с 2 параметрами, когда a != b, с 1 параметром, когда a == b, и конструктор без параметров по умолчанию, в котором стороны будут заполняться как a = 6, b = 4.

namespace Task6_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Rectangle
    {
        public int a;
        public int b;

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int side)
        {
            a = side;
            b = side;
        }

        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }

        public int Square()
        {
            return a * b;
        }
    }
}

