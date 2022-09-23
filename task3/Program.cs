// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите число дня недели от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 6 && a > 0)
    Console.WriteLine("Нет, это будний день :(");
else 
    {
        if (a > 7 || a == 0)
       Console.WriteLine("Упс, такого дня недели не существует.");
    else
    Console.WriteLine("Ура-а, это выходной!");
    }