using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsAndPattern
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine(
                    "\n1. Создать окружность\n" +
                    "2. Создать прямоугольник\n" +
                    "0. Выход"
                );

                Console.Write("\nВыберите действие: ");
                string choice = Console.ReadLine()!;

                try
                {
                    if (choice == "0")
                    {
                        break;
                    }

                    if (choice == "1")
                    {
                        Console.Write("Введите X центра: ");
                        double x = double.Parse(Console.ReadLine()!);

                        Console.Write("Введите Y центра: ");
                        double y = double.Parse(Console.ReadLine()!);

                        Console.Write("Введите радиус: ");
                        double radius = double.Parse(Console.ReadLine()!);

                        if (radius < 0)
                        {
                            throw new ArgumentException(
                                "Радиус не может быть отрицательным."
                            );
                        }

                        Circle circle = new Circle(
                            new Point(x, y),
                            radius
                        );

                        Console.WriteLine(
                            $"Результат: {ShapeClassifier.Classify(circle)}"
                        );
                    }
                    else if (choice == "2")
                    {
                        Console.Write("Введите X верхней левой точки: ");
                        double x1 = double.Parse(Console.ReadLine()!);

                        Console.Write("Введите Y верхней левой точки: ");
                        double y1 = double.Parse(Console.ReadLine()!);

                        Console.Write("Введите X нижней правой точки: ");
                        double x2 = double.Parse(Console.ReadLine()!);

                        Console.Write("Введите Y нижней правой точки: ");
                        double y2 = double.Parse(Console.ReadLine()!);

                        Rectangle rectangle = new Rectangle(
                            new Point(x1, y1),
                            new Point(x2, y2)
                        );

                        Console.WriteLine(
                            $"Результат: {ShapeClassifier.Classify(rectangle)}"
                        );
                    }
                    else
                    {
                        Console.WriteLine("Такого пункта нет.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: нужно ввести число.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}