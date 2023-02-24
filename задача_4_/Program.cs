Console.Clear();
Console.WriteLine("Задайте первое измерение массива");
int arrayX = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте второе измерение массива");
int arrayY = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте третье измерение массива");
int arrayZ = int.Parse(Console.ReadLine());
int[] array = BuildArray(arrayX, arrayY, arrayZ);

int[] BuildArray(int x, int y, int z)
{
    int[] inArray = new int[x*y*z];
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] = new Random().Next(10,100);
    }
    return inArray;
}
Console.WriteLine("создан массив:");
Console.Write($"[{String.Join(", ", array)}]");
Console.WriteLine(); Console.WriteLine(); 


int[] CheckArray (int[] arrayForCheck)
{
    for (int i = 0; i < arrayForCheck.Length; i++)
    {
        for (int j = i + 1; j < arrayForCheck.Length; j++)
        {
            if (arrayForCheck[i] == arrayForCheck[j])
            {
                arrayForCheck[j]=new Random().Next(10,100);
            }
        }
    }return arrayForCheck;}

Console.WriteLine("массив после проверки и замены повторений:");
CheckArray(array);
Console.Write($"[{String.Join(", ", array)}]");
Console.WriteLine();Console.WriteLine();

void MultiArray (int[] inArray, int x, int y, int z)
{
    int index = 0;
    int[,,] result = new int[x,y,z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
            result[i,j,k]=inArray[index++];
            Console.Write($"{result[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("многомерный массив:");
MultiArray(array, arrayX, arrayY, arrayZ);
