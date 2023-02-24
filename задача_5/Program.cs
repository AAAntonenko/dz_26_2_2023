Console.Clear();
Console.WriteLine("введите размер массива:");
int arraySize = int.Parse(Console.ReadLine());
int[,] array = CreateSpiralArray (arraySize,arraySize);

int[,] CreateSpiralArray (int size1, int size2)
{
int[,] array = new int[size1,size2];
int temp = 1;
int i = 0;
int j = 0;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
    array[i, j] = temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
    else
    i--;
    }return array;}

  void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);

