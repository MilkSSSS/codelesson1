﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input number");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
Console.WriteLine("True");
}
else {
Console.WriteLine("False");
}