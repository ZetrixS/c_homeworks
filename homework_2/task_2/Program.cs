//// Задача 2: Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.

//// Блок отвечающий за генерацию числа
int start = 1;
int stop = 100;
int random_value = new Random().Next(start, stop);
//// Блок отвечающий за вывод сообщени об успешной генерации
Console.WriteLine("Случайно сгенерированное число - " + random_value);
Console.WriteLine("Определяю третью по счету цифру в числе, или же выдаю сообщение об отсутсвтии оной...stand by....");
//// Блок отвечающий за саму механику выбора третьей цифры, или же сообщающий об ее отсутствии
///.1 Водим переменную "number_1" для работы цикла
int number_1 = 0;
int number_2 = 0;
///.2 Нам подойдет только число от 100 и выше, так как они имеет 3 цифры и более в себе
if (random_value > 99)
{
    if (random_value > 999)
    {
        if (random_value > 9999)
        {
            number_1 = random_value / 100;
            number_2 = number_1 % 10;
            Console.Write("Третья цифра по счету в нашем числе - " + number_2);
        }
        else 
        {
            if (random_value > 999)
            {
                number_1 = random_value / 10;
                number_2 = number_1 % 10;
                Console.Write("Третья цифра по счету в нашем числе - " + number_2);
            }
        }
    }
    else 
    {
        if (random_value > 99)
        {
            number_1 = random_value % 10;
            Console.Write("Третья цифра по счету в нашем числе - " + number_1);
        }
    }
}
else
{
    Console.Write("Число содержит менее трех символов." );
}





















