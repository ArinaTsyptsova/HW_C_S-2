Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine($"{num} -> да");
}
else 
{
    Console.WriteLine($"{num} -> нет");
}