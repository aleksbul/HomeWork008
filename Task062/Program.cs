// Напишите программу, которая заполнит спирально массив 4 на 4.


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
int[,] array = new int[4, 4];

int SpiralFillArray(int row, int col, int number, bool direction)
{
    if (col < array.GetLength(1) && row < array.GetLength(0) && col >= 0 && row >= 0 && array[row, col] == 0)
    {
        array[row, col] = number++;
        if (direction == false)
        {
            number = SpiralFillArray(row, col + 1, number, false);
            number = SpiralFillArray(row, col - 1, number, false);
            number = SpiralFillArray(row + 1, col, number, true);
            number = SpiralFillArray(row - 1, col, number, true);
        }
        else
        {
            number = SpiralFillArray(row + 1, col, number, true);
            number = SpiralFillArray(row - 1, col, number, true);
            number = SpiralFillArray(row, col + 1, number, false);            
            number = SpiralFillArray(row, col - 1, number, false);            
        }
    }
    return number;
}

SpiralFillArray(0, 0, 1, false);  
PrintArray(array);