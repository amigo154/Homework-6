// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

Console.WriteLine("Введите b1");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
var k2 = Convert.ToDouble(Console.ReadLine());

var x = (b2 - b1)/(k1 - k2);
var y = k1 * x + b1;

Console.WriteLine($"Точкой пересечения двух прямых будет ({x}; {y})");
