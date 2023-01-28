// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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

int rows = 6;
int columns = 5;
int[,] array = GetArray(rows, columns, 0, 9);

PrintArray(array);

int temp;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns - 1; j++)
    {
        for (int k = j + 1; k < columns; k++)
        {
            if (array[i, j] < array[i, k])
            {
                temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintArray(array);