/*
Задача 19: напишите программу, которая принимает на вход пятизначное число и проверяет, является ли 
оно палиндромом.

void PalindromNumber(int num)
{         
    if (num <= 9999 || num >= 100000)
        Console.Write("Incorrect number!");
    else
    {
        int n1 = num/10000;
        int n2 = (num/1000)%10;
        int n3 = (num/10)%10;
        int n4 = num%10;
        if (n1==n4 && n2==n3)
            Console.Write("Yes!");
        else
             Console.Write("No!");
    }
}
Console.Write("Input integer five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());  
PalindromNumber(num);
*/


/*
Задача 21: напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
в 3D пространстве.

double DistanceDtD(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));
}
Console.WriteLine("Введите координату x первой точки: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки: ");
int zB = Convert.ToInt32(Console.ReadLine());
Console.Write("A("  + xA + "," + yA + "," + zA + "); B(" + xB + "," + yB + "," + zB + ") -> " + DistanceDtD(xA, yA, zA, xB, yB, zB));
*/


/*
Задача 23: напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void InCube(int N)
{
    if (N > 0)
    {
        int count = 1;
        Console.Write( N + " -> ");
        while (count <= N)
        {
            Console.Write(count*count*count + " ");
            count++;
        }
    }
    else
    {
        int count = -1;
        Console.Write( N + " -> ");
        while (count >= N)
        {
            Console.Write(count*count*count + " ");
            count = count - 1;
        }
    }
        
}
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
InCube(num);
*/
        
            
  