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
int[,] ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t ");
            
        }
        Console.WriteLine();
    }
     return array;
}
/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы 
каждой строки двумерного массива.
*/
/*
int[,] SelectionSortLines(int[,] array)
{
    Console.WriteLine();
    
    for (int col = 0; col < array.GetLength(0); col++)
    {
        for (int row = 0; row < array.GetLength(1); row++)
        {
            int temporary = array[col, row];
            for (int tmp = row + 1; tmp < array.GetLength(1); tmp++)
            {
                if (array[col, tmp] < array[col, row])
                {
                temporary = array[col, tmp];
                array[col, tmp] = array[col, row]; 
                array[col, row] = temporary;
                }
            }
        }
    }
    return array;
}
int[,] MyArray = CreateArray(4, 7);
SelectionSortLines(MyArray);
ShowArray(MyArray);
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
*/
/*
void MinSumOfElementsInLine(int[,] array)
{
    
    int lineSum = 0;
    int minlineSum = 0;
    int findnum = 0;
    int lineOneSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        lineOneSum = lineOneSum + array[0,j];
        minlineSum = lineOneSum;
    } 
    //Console.WriteLine("1  " + lineOneSum);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        lineSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            lineSum += array[i, j];
        }
        //Console.WriteLine((i + 1) + "  " + lineSum);
        if (lineSum < minlineSum)
        {
            minlineSum = lineSum;
            findnum = i + 1;
        }
        else if (minlineSum == lineOneSum)
            findnum = 1;
    }
    //Console.WriteLine("The min is " + minlineSum);   
    Console.WriteLine("The search string is " + findnum);
}
int[,] MyArray = CreateArray(7, 9);
MinSumOfElementsInLine(MyArray);
*/

/*
Задача 62. Заполните спирально массив 4 на 4.
*/
/*
int[,] SpiralArray(int num1, int num2)
{
    int i = 0, j = 0; 
    int count = 1;
    int[,] array = new int[num1, num2];
    while (count <= num1 * num2)
    {
        array[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < num1 - 1)
            j++;
        else if (i < j && i + j >= num2 - 1)
            i++;
        else if (i >= j && i + j > num1 - 1)
            j--;
        else
            i--;
    }
    return array;
}
ShowArray(SpiralArray(4,4));
*/