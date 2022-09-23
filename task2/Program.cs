// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
string a = Convert.ToString(Console.ReadLine());
if (a.Length < 3)
    Console.WriteLine("У числа нет третьей цифры");
else     
    Console.WriteLine(a[2]);
 
