/* 
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
{
    Console.WriteLine("Maximum number is " + num1);
    Console.WriteLine("Manimum number is " + num2);
}
else
{
    Console.WriteLine("Maximum number is " + num2);
    Console.WriteLine("Manimum number is " + num1);
}


Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт
максимальное из этих чисел. 

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;
Console.WriteLine("Maximum number is " + max);


Задача 3: Напишите программу, которая на вход принимает число и выдаёт,
является ли число четным (делится ли оно без остатка).

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if((num % 2) == 0)
    Console.Write("This is an even number!");
else
    Console.Write("This is an odd number!");


Задача 4: Напишите программу, которая на вход принимает число (N), а на
выходе показывает все чётные числа от 1 до N.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    int current = num / num + 1;
    while (current <= num)
        {
            Console.Write(current + " ");
            current = current + 2;
        }
}
else
{
    int current = num;
    if ((num % 2) == 0)
        current = num;
    else
        current = num + 1;
    while (current >= num & current <= -2)
        {
            Console.Write(current + " ");
            current = current + 2;
        }
}

*/

