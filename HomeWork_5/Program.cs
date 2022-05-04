
/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void DegreeOfNumber (int A, int B)
{
    int num1 = A;
    int num2 = B;
    int prod = 1;
    int count = 0;
    if (num2 < 0)
        Console.WriteLine("Incorrect number B!!!");
    else
    {
        while (count < num2)
        {   
            prod = prod*num1;
            count++;
        }
        Console.WriteLine( A + "," + B + " -> " + prod + "(" + A + "^" + count + ")");
    }
     
}
Console.WriteLine("Input integeer number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input positiv integeer number B: ");
int B = Convert.ToInt32(Console.ReadLine());
DegreeOfNumber(A, B);
*/

/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void SumDigitofNumber(int usernumber)
{
    int num = usernumber;
    int sum = 0;
    while (num > 0)
        {
            sum += num%10;
            num = num/10;
        }
    Console.WriteLine("Sum of digit = " + sum);
}
Console.WriteLine("Input integeer number: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
SumDigitofNumber(usernumber);
*/

/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

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
Console.WriteLine("Input minimum array value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum array value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(8, min, max);
ShowArray(myArray);
*/