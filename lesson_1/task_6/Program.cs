﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число ");
int  namber = Convert.ToInt32(Console.ReadLine());

if (namber % 2 == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число не четное");
}