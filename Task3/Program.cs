int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}\t");
}

Console.WriteLine();

for (int i = 1; i < numbers.Length; i++)
{
    int key = numbers[i];
    int j = i - 1;

    while (j >= 0 && numbers[j] > key)
    {
        numbers[j + 1] = numbers[j];
        j--;
    }

    numbers[j + 1] = key;

    for (int k = 0; k < numbers.Length; k++)
    {
        Console.Write($"{numbers[k]}\t");
    }
    Console.WriteLine();
}
