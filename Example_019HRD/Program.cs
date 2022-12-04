Console.WriteLine("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Length (int num) // посчитали кол-во элементов
{
     int len= 0;
     while(num!=0){num=num/10; len++;}
     return len;
}
// Console.WriteLine(Length(num)); 
int size = Length(num);
int num1 = num;
int size1 = size;
int[] ar(int size) // Функция цикла складирования по элеметно задом наперед числа num
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = num%10;
        num=num/10;
    }
    return array;
}
int[] ar2(int[] array1, int size1) // Функция перевернутого первогоо цикла
{
     
    int[] array = new int[size1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array1[size1-1];
        size1=size1-1;
    }
    return array;
}

int[] array1 = ar(size);// создали цикл array1 для складирования поэлементно числа num
int[] array2 = ar2(array1, size1); // создан перевернутый цикл

for (int i = 0; i < size; i++)
{
    Console.Write($"{array1[i]} ");
}
for (int i = 0; i < size; i++)
{
    Console.Write($"{array2[i]} ");
}



// int[] numbers = new int[1000];
// int count=0;
// int x = num;
// while (x>0)
// {
//      x=x%10;
//      numbers[count]=x;  // сформировали цикл цифр составляющих числщ num
//      count++;
// }
// count = 0;
// while (count < numbers.Length) 
// {
//      if (numbers[count] = numbers[numbers.Length])
//      {
//           count++;
//           length--;
//      }
// } // написать цикл сравнивающий элементы массива между собой

// else {Console.WriteLine($"число {num} не является палиндромом");}