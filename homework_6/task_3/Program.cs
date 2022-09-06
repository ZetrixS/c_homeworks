//// Задача 3: * Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
//// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
//// Результат сложения вывести на экран.

//// Блок 1. Ввод цифры задающей размер массива
Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());

//// Блок 2. Создание массива на основании введенного числа
int [] massive = new int [input];

//// Блок 3. Заполнение массива произвольными числами
Console.Write("Ваш массив: ");
for (int l = 0; l < input; l++)
{
    massive[l] = new Random().Next(1, 10);
    Console.Write(massive[l] + " ");
}
Console.WriteLine();

//// Блок 4. Выполнение условия задачи
int massive_count = 0;
int i = 0;
int s = massive.Length;
int massive_summ = 0;

while (massive_count < massive.Length / 2)
{
    massive_summ += massive[i] * massive[s-1];
    i++;
    s--;
    massive_count++;   
}
//// Блок 5. Вывод результата
Console.Write("Резултат сложения перемноженных пар массива: ");
Console.Write(massive_summ);

//Console.Write(massive[i] + " " + massive[s-1]);