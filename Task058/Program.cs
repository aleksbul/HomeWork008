// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int m = 0; m < matrix1.GetLength(0); m++)
    {
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                result[m, k] += matrix1[m, n] * matrix2[n, k];
            }
        }

    }
    return result;
}


int row1 = 2;
int col1 = 5;
int row2 = 5;
int col2 = 2;

int[,] matrix1 = GetArray(row1, col1, 0, 9);
int[,] matrix2 = GetArray(row2, col2, 0, 9);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
int [,] matrixMult = MatrixMult(matrix1, matrix2);
PrintArray(matrixMult);
}
else Console.WriteLine("Матрицы нелья перемножить между собой, так как число столбцов первой матрицы не равно числу строк второй матрицы.");