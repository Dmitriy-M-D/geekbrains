// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число ");
int  namber_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int namber_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число ");
int namber_3 = Convert.ToInt32(Console.ReadLine());

int max = namber_1;

if (namber_2 > max)
{
    max = namber_2;
}
if (namber_3 > max)
{
    max = namber_3;
}
Console.Write("max = " + max);