﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
        Console.Write($"Введите {i+1} значение массива = " ); 
        array[i] = Convert.ToInt32(Console.ReadLine());  
    }
}

Console.Write("Введите размер массива M = ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
FillArray(array);

int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    count++;
}

Console.Write("Количество значений масиива больше 0 =  ");
Console.WriteLine(count);