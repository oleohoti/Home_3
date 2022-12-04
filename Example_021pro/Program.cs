    Console.Write("Введите колличество пространств, в которых находятся точки: ");
    int pros = Convert.ToInt32(Console.ReadLine());

    int pros1 = pros;
    int pros2 = pros;

    double [] A = new double [pros1]; // определяем размерность двух массивов
    double [] B = new double [pros2];
    
    for (int i=0; i<=pros1-1;i++) // цикл заполнения массивов значениями
    {
        Console.Write($"Введите координаты {i+1}-ого пространства точки А ");
        A[i] = Convert.ToDouble(Console.ReadLine());
    }

    double [] raz = new double [pros]; // размерность массива который будет заполняться разницой в квадрате для дальнейшего вывода из под корня
    double sum = 0; 

    for (int j=0; j<=pros-1;j++) // массив для заполнения разницы в квадрате и суммирования (формула без корня)
    {
        raz [j] = Math.Pow(B[i]-A[i],2); 
        sum=sum+raz[j];
        return sum;
        Console.WriteLine($"{raz[j]}");
        i++; 
    }
    
    double distance = Math.Sqrt(sum); // находим дистанцию финальной формулой
    Console.WriteLine($"Расстояние от точки А до точки B в {i}-ом пространсве равно: {distance}");
