using System;

class Program
{
    static void Main()
    {
        // Генерация двух случайных точек на плоскости
        Random random = new Random();

        int x1 = random.Next(100);
        int y1 = random.Next(100);
        int x2 = random.Next(100);
        int y2 = random.Next(100);
        //две точки
        double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        double dlinaokr = distance * 2;
        Console.WriteLine($"Точка 1: ({x1}, {y1})");
        Console.WriteLine($"Точка 2: ({x2}, {y2})");
        Console.WriteLine($"Расстояние между точками: {distance}");

        // Ожидание нажатия клавиши для выхода
        Console.ReadKey();
    }
}