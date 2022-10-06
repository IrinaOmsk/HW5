// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];

FillArray(array);
PrintArray(array);
Console.WriteLine(OddIndexSum(array));


void FillArray(int[] array)
{
    Random rand = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(-100, 100);
    }
}

int OddIndexSum(int[] array)
{
    int sum = 0;
    int length = array.Length;
    int i = 1;
    while (i < length)
    {
        sum = sum + array[i];
        i = i + 2;
    }
    return sum;
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