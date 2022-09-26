// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 1. Ввод чисел в терминал. Формируем числовой массив numbers из введенных
// чисел путем пеобразования строчного вида в числовой.
Console.Write("Введите числа через пробел: "); //Приглашение пользователя ввести числа.

// Вариант 1. 
// 1.1 Считываем строку с с консоли Console.ReadLine().
// 1.2 Получаем из этой строки строчный массив с помощью метода Split.
// 1.3 С помощью метода Array.ConvertAll и параметра int.Parse 
//     конвертируем строчный массив в числовой.
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

// Вариант 2. То же самое, только вместо Array.ConvertAll делаем через for.
//string userString = Console.ReadLine(); //Считывание строки с терминала.
//string[] array = userString.Split(" "); //Объявление строчного массива. Элементы массива разделены пробелом.
//int[] numbers = new int[array.Length]; //Объявление численного массива.
//for (int i = 0; i < array.Length; i++) 
//{
//    numbers[i] = int.Parse(array[i]); //Преобразование символа в число.
//}

// 2. Считаем количество чисел больше 0.
int greaterThan0 = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        greaterThan0++;
    }
}

// 3. Формируем формат введенных чисел и количества чисел больше 0.
// Выводим в терминал.
for (int i = 0; i < numbers.Length - 1; i++)
{
    Console.Write($"{numbers[i]},");
}
Console.Write($"{numbers[numbers.Length - 1]}");
Console.Write($" -> количество чисел больше 0: {greaterThan0}");