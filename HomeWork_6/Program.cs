/*
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
*/
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Console.WriteLine("How many digits do you want to use?: ");
int number = Convert.ToInt32(Console.ReadLine());
int size = number;
int[] userArray = new int[size];
int count = 0;
for (int i = 0; i < size; i++)
{
    Console.Write("Input " + i + " number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    userArray[i] = num;
    if (userArray[i] > 0)
        count++;
}
Console.Write("You input " + count + " positive numbers");
*/
/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
/*


int[] BinaryNumber (int num)
{
    int count = 0;
    int current = num;
    while (current > 0)
        {
            current = current / 2;
            count++;
        }
    int newSize =  count;
    
    int[] binarray = new int[newSize];
        for (int i = newSize-1; num > 0; i--)
    {
        
        if (num % 2 == 0)
        {
           binarray[i] = 0;
           num = num / 2;
           count++;
        }

        else
        {
           binarray[i] = 1;
           num = (num-1) / 2;
           count++;
        }
    
    }
    return binarray;
}
Console.WriteLine("Input integeer number: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int[] binarray = BinaryNumber (usernumber);
ShowArray(binarray);
*/

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
/*
Console.WriteLine("Введите значение k первой прямой: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k второй прямой: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b второй прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());

void CrossPoint(double k1, double b1, double k2, double b2)
{
    double a = (b2 - b1) / (k1 - k2);
    double b = k2 * a + b2;
    Console.WriteLine("X = " + a + " Y = " + b);
}
CrossPoint(k1, b1, k2, b2);
*/

