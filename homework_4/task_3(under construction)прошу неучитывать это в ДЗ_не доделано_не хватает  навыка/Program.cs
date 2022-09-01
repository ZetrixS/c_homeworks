//// Задача 3:*(Дополнительная, не обязательная задача): Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, 
//// которая заполняет массив на N «интересных» случайных целых чисел. (Каждый эл-т массива должен быть сгенерирован случайно)


//// Блок 1. Ввод числа
Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());

//// Блок 2. Создание массива на input чисел
int [] massive = new int [input];

//// Блок 3. Наполнение массива произвольными числами.
Random rand = new Random();
for (int l = 0; l < massive.Length; l++)
{
    massive[l] = rand.Next(1,1001);
    Console.WriteLine(massive[l] + "~");
}
//int s;
//int s_1 = 0;
//int [] massive_2 = new int [input];
//for (s = 0; s < massive_2.Length; s++)
//{
  //  massive_2[s] = massive[s_1];
    //s_1++;
//}
//int n_1 = 0;
//int count_1 = 1;
//while (massive_2[n_1] != 0)
//{
  //  if (massive_2[n_1] % 10 != 0)
    //{
    //count_1 *= massive_2[n_1] % 10;
    //massive_2[n_1] /= 10;
    //}
    //else
    //{
      //  massive_2[n_1] /= 10;
    //}
//}

//int n_2 = 0;
//int count_2 = 0;
//while (massive[n_2] != 0)
//{
  //  count_2 += massive[n_2] % 10;
    //massive[n_2] /= 10;
    
//}

//Console.WriteLine(count_1 + " " + count_2 );
//Console.Write(massive[n_1] % 10);
//int i;
//for (i = 0; i < input; i++)
//{
  //  if (count_1 % count_2 == 0)
    //{
      //  Console.WriteLine(massive[i] + "--->" + " интересное");
    //}
    //Console.WriteLine(massive[i] + "--->" + " не интересное");
//}

static int[] massive_rework_1(int[] arr, int n)
{
    int i;
    int [] t_arr = arr;
    int count_t = 1;
    for (i = 0; i < n; i++ )
    {
        
        while (t_arr[i] != 0)
        {
    
            if (t_arr[i] % 10 != 0)
            {
                count_t *= t_arr[i] % 10;
                t_arr[i] /= 10;
            }
            else
            {
                t_arr[i] /= 10;
            }
        } 
    }
    return t_arr;
}
int z = 0;
massive_rework_1( massive, input);
Console.Write(massive[z]);