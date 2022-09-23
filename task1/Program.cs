// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100 || a > 999)
    Console.WriteLine("Это не трёхзначное число, попробуйте снова!");
else
    Console.WriteLine((a % 100) / 10);