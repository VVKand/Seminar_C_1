// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все четные числа до " + N);
double x = 2;
while (x <= N)
{
    double z = x % 2.0;
    if (z > 0)
    {
     x = x + 1; 
    }
    else
    {
    Console.Write(x +", ");
    x = x + 1;
    }
}