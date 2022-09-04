//// Задача 3*: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//// Блок 1. Ввод цифры задающей размер массива
Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());

//// Блок 2. Создание массива на основании введенного числа
int [] massive = new int [input];

//// Блок 3. Заполнение массива произвольными трехзначными числами

Console.WriteLine("Построение массива.....");
Console.Write("Ваш массив ====> ");
for (int l = 0; l < input; l++)
{
    massive[l] = new Random().Next(100, 1000);
    Console.Write(massive[l] + " ");
}

//// Блок 4. Выполнение условий задачи
///.1 Создания фунции поиска max значения в массиве

int massiveMax (int [] massives)
{
    int i = 0;
    int l;
    int max = massive[i];
    for (l = 0; l < input; l++)
        {
            if (massive[i] > max)
            { 
                max = massive[i];
            }
            i++;
        }
    
    return max;
}

///.3 Создание функции поиска min значения в массиве

int massiveMin (int [] massives)
{
    int i = 0;
    int l;
    int min = massive[i];
    for (l = 0; l < input; l++)
        {
            if (massive[i] < min)
            { 
                min = massive[i];
            }
            i++;
        }
    
    return min;
}

///.4 Выяснение разницы в числах

int number = massiveMax(massive) - massiveMin(massive);


Console.WriteLine();
Console.WriteLine("MAX - " + massiveMax(massive) + " " + "MIN - " + massiveMin(massive));
Console.WriteLine($"Разница между максимальным и минимальным значением массива: {number}");