
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int SumOfElementsRec(int m, int n)
{
    int sum = 0;
    if (m <= n)
        sum += m + SumOfElementsRec(m+1, n);
    return sum;
}
Console.Write(SumOfElementsRec(3, 15));
*/
/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
/*
int SumDigitOfNumberRec(int usernum)
{
    int sum = 0;
    int num = usernum;
    if (num < 10)
        sum = num;
    else
        sum += num % 10 + SumDigitOfNumberRec(num / 10);
    return sum;
    Console.Write("The sum of digits is " + sum);
}
Console.Write("Input integer number: ");
int usernum = Convert.ToInt32(Console.ReadLine());
Console.Write(SumDigitOfNumberRec(usernum));
*/