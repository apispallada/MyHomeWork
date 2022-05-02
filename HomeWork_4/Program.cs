int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void NumberOfEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        count++;
    }
    Console.WriteLine("Number of even elements = " + count);
}

void SumOfOddElements (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i +=2)
        sum += array[i];
    Console.WriteLine("The sum of odd elements = " + sum);
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int max = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[max]) max = j;
        }
        int temporary = array[i];
        array[i] = array[max];
        array[max] = temporary;
    }
}

void DifferenceMaxMin(int[] array)
{
    int size = array.Length;
    int max = array[0];
    int min = array[size - 1];
    int diff = (max - min);
    Console.WriteLine("The difference = " + diff);
}

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

int[] myArray = CreateRandomArray(16, 100, 999);
ShowArray(myArray);
NumberOfEvenElements(myArray);
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
нечётных позициях.

int[] myArray = CreateRandomArray(12, 0, 10);
ShowArray(myArray);
SumOfOddElements(myArray);
*/
 
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементами массива.
*/
int[] myArray = CreateRandomArray(15, 0, 1000);
ShowArray(myArray);
SelectionSort(myArray);
ShowArray(myArray);
DifferenceMaxMin(myArray);
