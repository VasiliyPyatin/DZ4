// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;
using static System.Console;

Clear();

Write("Введите число: ");
WriteLine ($"Сумма цифр = {GetSumNumber(Convert.ToInt32(ReadLine()))}");

int GetSumNumber (int number)
{
    int sum = 0;
    int count = Convert.ToString(number).Length;
    for (int i = 0; i < count; i++)
    {
        sum = sum + (number - (number-number%10));
        number = number/10;
    }
    return sum;
}