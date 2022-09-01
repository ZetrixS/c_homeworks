//// Задача 2:* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, 
//// которые являются делителями этого числа. (для получения цифр числа операцию приведения числа к строке не использовать)


//// Блок 1. Введение числа

Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());

//// Блок 2. Перевод нашего числа в массив.
///.1 Вычисление кол-ва чисел и добавление их в массив, посредством функции.
int input_temp = input;
int input_temp_1 = input;
int numbers_count (int digits)
{
    int i = 0;
    while (input_temp_1 != 0)
    {
        input_temp_1 /= 10;
        i++;
    }
    return i;
}
int massive_lenght = numbers_count(input);
int [] massive = new int [massive_lenght];

///. 2 Наполнениек массива посредством цикла
int i;
for(i = massive_lenght -1; i != -1; i--)
{
    massive[i] = input_temp %10;
    input_temp /=10;
}

//// Блок 3. Провермяем цифры на соответсвие нашему условию и складываем их

///int l = 0;
///while(l < massive_lenght)
///{
    ///Console.Write(massive[l] + " ");
    ///l++;
///}
int count = 0;
int massive_i = 0;
while(massive_i < massive_lenght)
{
    if (massive[massive_i] != 0)
    {
        if(input % massive[massive_i] == 0)
        {
            count += massive[massive_i];
            massive_i++;
        }
        else
        {
            massive_i++;
        }
        massive_i++;
    }
}    
 Console.Write(count);
