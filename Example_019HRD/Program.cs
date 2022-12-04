Console.WriteLine("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Length (int num) // посчитали кол-во элементов
{
     int len= 0;
     while(num!=0){num=num/10; len++;}
     return len;
}
Console.WriteLine(Length(num)); 
int num1 = num;
int i = 0;
int j = 0;
int[] array1 = new int[Length(num)];// создали цикл array1 для складирования поэлементно числа num
for ( i=0; i<Length(num); i++) {array1[i]=num1%10; num1 = num1/10;}
int size = Length(num);
int[] array2 = new int[Length(num)];
for ( j=0; j<Length(num); j++) {array2[j]=array1[size]; size=size-1;}
while (i<size) {if (array1[i]!=array2[j]){Console.WriteLine("число палиндримом не является");} else {i++;j++;} if(array1[size] == array2[size]){Console.WriteLine("число является ");}}



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