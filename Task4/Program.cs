//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input positive number");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i<a){
if (i % 2 == 0)
Console.WriteLine(i);
i++;
}
Console.WriteLine("Finish");