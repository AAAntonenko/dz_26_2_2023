Console.Clear();
Console.WriteLine("Задайте число строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте число элементов массива");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray (rows, columns);

int[,] GetArray (int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

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
Console.WriteLine();
Console.WriteLine("Отсортированный массив");

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

void CreateTempArray (int[,] array)
{
int[] tempArray = new int[columns];
     for (int i = 0; i < rows; i++)
     {
         for (int j = 0; j < columns; j++)
             tempArray[j] = array[i, j];
         SortArray(tempArray);
         Console.WriteLine(String.Join(" ", tempArray));
     }
}

CreateTempArray(array);