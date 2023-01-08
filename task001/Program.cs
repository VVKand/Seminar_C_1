// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
Console.WriteLine("Введите число 1");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write(" a=" + x);
Console.Write(" b=" + y);
if (x > y)
{
    Console.Write(" max=" + x);
}
else
{
    Console.Write(" max=" + y);
}