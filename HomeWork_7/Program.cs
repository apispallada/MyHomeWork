/*
int[,] CreateArray(int num1, int num2)
{
    int[,] array = new int[num1, num2];
    for (int i = 0; i < num1; i++)
    {
        for (int j = 0; j < num2; j++)
        {
            array[i, j] = new Random().Next(0,20);
            Console.Write(array[i,j] + "\t" );
        }
        Console.WriteLine();
    }
    return array;
}
*/

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4. 
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

double ArrayOfRandomNambers(int size1, int size2)
{
    double[,] array = new double[size1,size2];
    Random num = new Random();
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array[i,j] = Convert.ToDouble(num.Next(-100,100) / 10.0);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array[size1-1, size2-1];
}
ArrayOfRandomNambers(9, 9);
*/


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

void FindElementOfMassiv(int[,] array, int a, int b)
{
    int i = a-1;
    int j = b-1;
    int findNum;
    if (a >= array.GetLength(0) || b >= array.GetLength(1))
        Console.WriteLine($"The number not exist!");
    else
    {
        findNum = array[i, j];
        Console.WriteLine("The number is " + findNum);
    }
}
Console.Write("Input first index of element: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second index of element: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] MyArray = CreateArray(7, 7);
FindElementOfMassiv(MyArray, a, b);
*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void AverageColumn(int[,] array)
{
    
    double result = 0;   
    for (int col = 0; col < array.GetLength(1); col++)
    {
         double sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
           
            sum += array[row, col];
            
        }
        result = sum / array.GetLength(0);
        Console.Write( result + "\t");
    }
}
AverageColumn(CreateArray(4,4));
*/
 