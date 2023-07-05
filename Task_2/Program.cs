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
