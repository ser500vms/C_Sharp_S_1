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