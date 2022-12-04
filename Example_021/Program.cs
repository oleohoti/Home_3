// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double input(string k, string b)
{
    Console.WriteLine($"Введите {k} координату точки {b}");
    return Convert.ToDouble(Console.ReadLine());
}

try
{
    double xA = input("x", "A");
    double yA = input("y", "A");
    double zA = input("z", "A");
    double xB = input("x", "B");
    double yB = input("y", "В");
    double zB = input("z", "B");// N=Math.Row((kB),2)

    double result = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
    Console.WriteLine("Расстояние между точками: " + Math.Round(result, 2));
}
catch
{
    Console.WriteLine("Ошибка выполнения");// A (3,6,8); B (2,1,-7), -> 15.84
}