﻿int[] array = { 7, 0, -4, 3, 1, -2, 5 };

for (int i = 0; i < array.Length - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[min])
        {
            min = j;
        }
    }
    int temp = array[i];
    array[i] = array[min];
    array[min] = temp;

    Console.WriteLine();
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}\t");
    }
}



