/*
Задача 10: Написать программу, которая принимает на вход трехзначное число и
на выходе показывает вторую цифру этого числа.

void ShowSecondNumber(int num)
{
    if (num < -999 & num > -100 || num < 100 & num > 999)
        Console.Write("Incorrect number!");
    else
    {
        if (num >= 100 & num <= 999)
        {
        int n1 = num%100;
        int n2 = n1/10;
        Console.Write(num  + " -> Second number is " + n2);
        }
        else
        {
            int num1 = num%100;
            int num2 = -1*(num1/10);
            Console.Write(num  + " -> Second number is " + num2);
        }
    }
}
Console.Write("Input integer three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowSecondNumber(num);


Задача 13: Написать программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.

void ThirdDigit(int num)
{
    if (num > -100 & num < 100)
        Console.Write("Third digit isn't exist!");
    else if (num > 999)
        {
        int currentnum = num;
        do
        currentnum = currentnum/10;
        while (currentnum > 999);
        int n1 = currentnum%10;
        Console.Write(num + " -> Third digit is " + n1);
    }
    else if (num < - 999)
    { 
        int currentnum = num;
        do
            currentnum = currentnum/10;
        while (currentnum < -999);
        int n2 = currentnum%10*(-1);
        Console.Write(num + " -> Third digit is " + n2);
    }
    else if (num > 99 & num < 1000)
    {
        int n1 = num%10;
        Console.Write(num + " -> Third digit is " + n1);
    }
    else if (num > -1000 & num < -99)
    {
        int num1 = num%10;
        int num2 = -1*num1;
        Console.Write(num  + " -> Therd digit is " + num2);
    }
          
}
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdDigit(num);


Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
недели, и проверяет, является ли этот день выходным.

void ShowWeekDay(int num)
{
    if (num < 1 || num > 7)
        Console.Write("Incorrect number!");
    else
    {
        if (num == 6 || num == 7)
            Console.Write("Wow! it's a day off!");
        else
            Console.Write("Sorry, it's a working day. ");
        
    }
}
Console.Write("Input numder of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());
ShowWeekDay(day);
*/





