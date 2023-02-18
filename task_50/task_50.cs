// Задача 50: Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 11);
        }
    }
    return matr;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintCoordinate(int[,] matrix, int x, int y)
{
    if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
    {
        System.Console.Write($"Значение элемента с координатами({x},{y}): {matrix[x, y]}");
    }
    else
    {
        System.Console.Write("Такого числа в массиве нет.");
    }
}
int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
int x = ReadInt("Введите позицию x: ");
int y = ReadInt("Введите позицию y: ");
var mymatrix = GenerateArray(rows, cols);
PrintMatrix(mymatrix);
System.Console.WriteLine();
PrintCoordinate(mymatrix, x, y);

