// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] GetArray(int row, int column, int start, int end)
{
    int[,] result = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(start, end + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = 5;
int columns = 6;
int[,] array = GetArray(rows, columns, 0, 9);

PrintArray(array);

int[] sums = new int[rows];
int k = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        sums[k] += array[i, j];
    }
    k++;
}

int minSumRow = sums[0];
int minRow = 0;
for (k = 1; k < rows; k++)
{
    if (sums[k] < minSumRow)
    {
        minSumRow = sums[k];
        minRow = k;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow + 1}");