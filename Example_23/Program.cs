// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= num)
{
    int cube = count*count*count;
    Console.WriteLine($"Таблица кубов: {cube}");
    count++;
}
