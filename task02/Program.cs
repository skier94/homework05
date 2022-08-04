//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GetArray(12, -10, 10);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", result), "]");
    return result;
}

int Count(int[] ar)
{
    int j = 0;

    for (int i = 0; i < ar.Length; i++)
    {
        if (i % 2 == 0)
        {
            j += ar[i];
        }
    }

    return j;
}

Console.WriteLine($"{Count(array)} сумма нечётных чисел");