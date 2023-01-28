// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] GetArray(int row, int col, int tub, int start, int end)
{
    int[,,] result = new int[row, col, tub];
    int[] check = new int[end + 1];
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < tub; k++)
            {
                int number;
                do
                {
                    number = new Random().Next(start, end + 1);
                }
                while (check[number] != 0);
                result[i, j, k] = number;
                check[number] = 1;

            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) \t");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array = GetArray(2, 2, 2, 10, 99);

PrintArray(array);