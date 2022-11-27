/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 Через строку решать нельзя.*/
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int first = num/10000;
int second = num%10000/1000;
int fourth = num%100/10;
int five = num%10;
if ( first == five){Console.WriteLine($"число {num} является палиндромом");}
else {Console.WriteLine($"число {num} является палиндромом");}
