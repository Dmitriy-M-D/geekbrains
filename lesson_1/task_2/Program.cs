// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число ");
int  namber_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int namber_2 = Convert.ToInt32(Console.ReadLine());

if (namber_1 > namber_2)
{
    Console.WriteLine("max = " + namber_1);
}
else
{
    Console.WriteLine("max = " + namber_2);
}