Console.WriteLine("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int x = num;
while (x<10)
{
     x=x/10;
}
int first = num/10000;
int second = num%10000/1000;
int fourth = num%100/10;
int five = num%10;
if ( first == five && second == fourth) {Console.WriteLine($"число {num} является палиндромом");}
else {Console.WriteLine($"число {num} не является палиндромом");}