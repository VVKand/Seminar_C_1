// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Число четное?");
double z = x % 2.0;
if (z > 0)
{
   Console.Write(" Нет."); 
}
else
{
    Console.Write(" Да!");
}
