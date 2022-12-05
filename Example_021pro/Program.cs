Console.Write("Введите колличество пространств, в которых находятся точки: ");
int pros = Convert.ToInt32(Console.ReadLine());

double []array1 (int pros)
{
    double [] mass = new double [pros];
    for (int i=0; i<=pros-1;i++) // цикл заполнения массивов значениями
    {
    Console.Write($"Введите координаты {i+1}-ого пространства точки А ");
    mass[i] = Convert.ToDouble(Console.ReadLine());
    }
    return mass;
}
double [] A=array1(pros);

double []array2 (int pros)
{
    double [] mass = new double [pros];
    for (int i=0; i<=pros-1;i++) // цикл заполнения массивов значениями
    {
    Console.Write($"Введите координаты {i+1}-ого пространства точки B ");
    mass[i] = Convert.ToDouble(Console.ReadLine());
    }
    return mass;
}
double [] B=array2(pros);

double []raz (double[]A,double[]B, int pros)
{
    double [] mas = new double [pros];
    for (int i=0; i<=pros-1;i++) // цикл заполнения массивов значениями
    {
     mas[i]=Math.Pow(B[i]-A[i],2);
    }
    return mas;
}
double []raznica = raz(A,B,pros);



double distance(double[]raznica)
{
    double sum = 0;
    for (int i=0;i<raznica.Length;i++)
    {
        sum=sum+raznica[i];
    }
    double dis = Math.Sqrt(sum);
    return dis;
}

    // double [] raz = new double [pros]; // размерность массива который будет заполняться разницой в квадрате для дальнейшего вывода из под корня
    // double sum = 0; 

    // for (int j=0; j<=pros-1;j++) // массив для заполнения разницы в квадрате и суммирования (формула без корня)
    // {
    //     raz [j] = Math.Pow(B[i]-A[i],2); 
    //     sum=sum+raz[j];
    //     Console.WriteLine($"{raz[j]}");
    //     i++; 
    // }
    
    // double distance = Math.Sqrt(sum); // находим дистанцию финальной формулой
Console.WriteLine($"Расстояние от точки А до точки B в {pros}-х мерном пространсве равно: {distance(raznica)}");//A (3,6,8); B (2,1,-7), -> 15.84
