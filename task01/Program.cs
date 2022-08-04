//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);

    }
    return result;
}

int[] array = GetArray(12, 100, 1000);

foreach (int i in array)
{
    Console.Write($" {i} ");
}

Console.WriteLine();

int Count(int[] ar)
{
    int j = 0;

    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] % 2 == 0) j = j + 1;
    }

    return j;
}

Console.WriteLine($"{Count(array)} количество чётных чисел");