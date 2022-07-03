// Урок 4. Функции продолжение
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;
using static System.Console;

Clear();

WriteLine("Введите число A: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число B: ");
int b = Convert.ToInt32(ReadLine());

double pow = GetPow (a, b);
WriteLine (pow);

// double GetPow (int ra, int rb)
// {
//     double result = Math.Pow(ra, rb);

//     return result;
// }

int GetPow (int ra, int rb)
{
    int result = 1;
    for (int i=1; i <= rb; i++)
    {
        result = result * ra;

    }
    return result;
}



