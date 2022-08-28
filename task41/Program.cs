int [] ArrayNum(int Length)
{
    int [] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        Console.Write("Введите любое число ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}");
    Console.WriteLine();
}

int PositiveArray (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
Console.Write("Введите кол-во вводимых чисел ");
int arrayLenght = Convert.ToInt32(Console.ReadLine());
int [] array = ArrayNum(arrayLenght);
PrintArray(array);
Console.Write($"Кол-во положительных чисел = {PositiveArray(array)}");