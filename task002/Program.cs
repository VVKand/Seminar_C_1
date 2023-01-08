//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число 1");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write(" a=" + x);
Console.Write(" b=" + y);
Console.Write(" c=" + z);
if (x > y && x > z)
{
  Console.Write(" max=" + x); 
}
else if (y > x && y > z)
{
    Console.Write(" max=" + y);
}
else if (z > x && z > y)
{
    Console.Write(" max=" + z);
}
