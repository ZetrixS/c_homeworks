//// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//// Блок отвечающий за выбор дня по номеру
int day = 0;
Console.Write("Выберите день недели, указав его номер: ");
string input = Console.ReadLine();
day = Convert.ToInt32(input);
//// Блок отвечает за сравнение номера с днем недели, и выводом соответствующего сообщения
switch (day)
{
    case 1:
    Console.WriteLine("Вы выбрали - Понедельник.");
    Console.Write("Понедельник не является выходным днем.");
    break;

    case 2:
    Console.WriteLine("Вы выбрали - Вторник.");
    Console.Write("Вторник не является выходным днем.");
    break;

    case 3:
    Console.WriteLine("Вы выбрали - Среду.");
    Console.Write("Среда не является выходным днем.");
    break;

    case 4:
    Console.WriteLine("Вы выбрали - Четверг.");
    Console.Write("Четверг не является выходным днем.");
    break;

    case 5:
    Console.WriteLine("Вы выбрали - Пятницу.");
    Console.Write("Пятница не является выходным днем.");
    break;

    case 6:
    Console.WriteLine("Вы выбрали - Субботу.");
    Console.Write("Суббота является выходным днем.");
    break;

    case 7:
    Console.WriteLine("Вы выбрали - Воскресенье.");
    Console.Write("Воскресенье является выходным днем.");
    break;
}
