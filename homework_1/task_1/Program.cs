int max = 0;
int min = 0;
int first_number = 0;
int second_number = 0;
Console.Write("Введите первое число:");
string input_1 = Console.ReadLine();
first_number = Convert.ToInt32(input_1);
Console.Write("Введите второе число:");
string input_2 = Console.ReadLine();
second_number = Convert.ToInt32(input_2);
if (first_number == second_number)
{
    Console.WriteLine("Ошибка, вы ввели два равных числа. Программа предназначена для выяснения большего и меньшего чисел.");
}
else
{
    if (first_number > second_number)
    {
        max = first_number;
        min = second_number;
    }
    else
    {
        max = second_number;
        min = first_number;
    }
    Console.WriteLine("Максимальное:" + max);
    Console.WriteLine("Минимальное:" + min);
}
