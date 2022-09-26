/// Задача 43: Напишите программу, которая найдёт точку пересечения двух
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// Вводим значения переменных.
Console.WriteLine("Прямые заданы уравнениями: y=k1*x+b1 и y=k2*x+b2");
Console.WriteLine("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

// Проверяем прямые на совпадение и параллельность.
if (b1 == b2 && k1 == k2)
{
     Console.Write("Прямые совпадают.");
}
else if ((b1 * k2 - b2 * k1) == 0)
{
     Console.Write("Прямые параллельны."); 
}
else
{
// Вычисляем точку пересечения прямых.
double x = Math.Round((b2 - b1) / (k1 - k2), 1); // Округляем до десятых.
double y = Math.Round(k1 * (b2 - b1) / (k1 - k2) + b1, 1); // Округляем до десятых.

// Выводим в терминал заданные координаты и координаты точки пересечения прямых.
Console.Write($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({x}, {y})");
}