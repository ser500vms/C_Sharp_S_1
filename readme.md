Первое задание: 
// Напишите программу, которая на вход принимает число и выдает его квадрат 
// (число умноженное на само себя)

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// 1. Надо попросить ввести число
// 2. Записать число в переменную
// 3. Умножить число на тоже число и записать новую переменную
// 4. Вывести результат


Console.Write("Введите число: ");
int number =int.Parse(Console.ReadLine());
int sqr = number * number;
Console.Write($"Квадрат числа {number} равен " + sqr);

// $ - значит в скобках есть переменная, которую мы обозначили {}, + значит добавляем к строке следующий элемент
// Результат в терминале
// Введите число: 5
// Квадрат числа 5 равен 25

// Задача №2:
// Напишите программу , которая будетвыдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число от 1-го до 7-ми: ");
int number =Convert.ToInt32(Console.ReadLine());

if(number == 1) Console.Write("Сегодня Понедельник ");

if(number == 2) Console.Write("Сегодня Вторник ");

if(number == 3) Console.Write("Сегодня Среда ");

if(number == 4) Console.Write("Сегодня Четверг ");

if(number == 5) Console.Write("Сегодня Пятница ");

if(number == 6) Console.Write("Сегодня Суббота ");

if(number == 7) Console.Write("Сегодня Воскресенье ");

// Задача №3:
// Напишите программу, которая на вход принимает два числа и
// проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет




Console.Write("Введите 1-е число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.Write($"{numberA} является квадратом числа {numberB} ");
}
else
{
    Console.Write($"{numberA} не является квадратом числа {numberB} ");
}

// Задача №4:
// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// -4 -> "4, 3, 2, 1, 0, -1, -2, -3, -4"*


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
    for (int i = -number; i <= number; i++)
Console.Write(i + ", ");
}
else
{
    for (int i = -1 * number; i >= number; i--)
Console.Write(i + ", ");
}

// Задача №5:
// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number % 10);