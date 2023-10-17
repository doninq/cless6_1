/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
//using System.CodeDom.Compiler;

int[] GenerateArroy(int m)
{
    int[] Arr = new int[m];
    for(int i = 0; i < m; i++)
    {
    Console.WriteLine("Введите число: " + (i+1));
    Arr[i] = Convert.ToInt32(Console.ReadLine()!);
    }
    return Arr;
}
void PrintArray(int[] Arr)
    {
    Console.Write("[ ");  
    
    for (int i = 0; i < Arr.Length; i++)
    {
    Console.Write(Arr[i] + " ");        
    }
    Console.Write("]");  
    }
int HighThenNull(int[] Arr)
{
    int plus = 0;
    for(int i = 0; i < Arr.Length; i++)
    {
       if (Arr[i] > 0) plus++;
    }
    return plus;
}

Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine()!);
int[] Arr = GenerateArroy(m);
PrintArray(Arr);
Console.WriteLine("Количество чисел больше 0: " + HighThenNull(Arr));
