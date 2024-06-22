int[] array = { 7, 0, -4, 3, 1, -2, 5 };
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    Console.WriteLine();
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}\t");
    }
}
