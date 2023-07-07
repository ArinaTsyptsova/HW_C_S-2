// Задача 1
// Напишите программу, которая принимает на вход трехзначное число и на выходе
// показывает вторую цифру этого числа

Console.WriteLine("Введите число от 100 до 999: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num >= 1000)
{
     Console.WriteLine("Некорретное число");
}
else 
{
    int secondDidgit  = (num / 10) % 10;
    Console.WriteLine($"{num} -> {secondDidgit}");
}