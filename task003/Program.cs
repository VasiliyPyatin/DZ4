// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;
using static System.Console;

Clear();
int[] array=new int[8];
FillArray(array);
PrintArray(array);


void FillArray (int [] ar)
{
    for (int i = 0; i<ar.Length; i++)
    {
        ar[i] = new Random().Next(0,9);
    }
    
}

void PrintArray (int [] ray)
{
    Write("[");
    for (int i = 0; i<ray.Length-1; i++)
    {
        Write($"{ray[i]},");
    }
    Write($"{ray[ray.Length-1]}]");
}