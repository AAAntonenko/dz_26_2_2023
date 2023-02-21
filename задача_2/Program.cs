Console.Clear();
Console.WriteLine("Задайте число строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте число элементов массива");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray (rows, columns);
int[,] array2 = GetArray (rows, columns);
if (rows != columns) {Console.WriteLine("Число строк и столбцов должно быть одинаковым");return;}

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
Console.WriteLine("первая матрица");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("вторая матрица");
PrintArray(array2);
Console.WriteLine();

void ProductOfArrays (int[,] matrix1, int[,] matrix2)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = matrix1[i, j]*matrix2[i, j];
            Console.Write($"{newArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("произведение матриц");
ProductOfArrays(array, array2);