// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];

FillArray(array);
PrintArray(array);
Console.WriteLine(MaxMinDifference(array));

void FillArray(int[] array)
{
    Random rand = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(1, 100);
    }
}

int MaxMinDifference(int[] array)
{
    int max = array[0];
    int min = array[0];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (max < array[i])
        max = array[i];

        if (min > array[i])
        min = array[i];

    }
    return max - min;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}
