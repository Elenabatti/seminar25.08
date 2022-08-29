// Напишите программу, котрая принимает на вход число(N) и выдаёт таблицу квадратов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (count <= n)
{
    Console.Write($"{Math.Pow(count, 2)} ");
    count ++;
}
Console.WriteLine();
