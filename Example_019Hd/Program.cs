int[] array1 = { 2, 1, 3, 4, 5, 2 };

int[] array2 = { 2, 1, 3, 4, 5, 2 };

string mes(int[]array1, int[]array2)
{
bool ans = true;

if (array1.Length != array2.Length)
{
    ans = false;
}
else
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            ans = false;
        }
    }
}

string str = "";

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
Console.WriteLine(mes(array1,array2));