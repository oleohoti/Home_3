﻿// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.
Console.WriteLine("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int size = Length(num);
int num1 = num;
int size1 = size;
int Length(int num) // посчитали кол-во элементов
{
    int len = 0;
    while (num != 0) { num = num / 10; len++; }
    return len;
}
int[] ar(int size) // Функция цикла складирования по элеметно задом наперед числа num
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = num % 10;
        num = num / 10;
    }
    return array;
}
int[] ar2(int[] array1, int size1) // Функция перевернутого первогоо цикла
{

    int[] array = new int[size1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array1[size1 - 1];
        size1 = size1 - 1;
    }
    return array;
}
string mes(int[] array1, int[] array2) // Функция сравнения
{
    bool ans = true;
    string str = "";
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            ans = false;
        }
    }
    
    if (ans == true)
    {
        str = "Число является палиндромом";
    }

    if (ans == false)
    {
        str = "Число не является палиндромом";
    }
    return str;
}
int[] array1 = ar(size);// создали цикл array1 для складирования поэлементно числа num
int[] array2 = ar2(array1, size1); // создан перевернутый цикл
Console.WriteLine(mes(array1, array2));

