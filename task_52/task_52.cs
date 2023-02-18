//  Задача 52: Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void Average(int[,] matr)
{
    int[] sum = new int[matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum[i] += matr[j, i];
        }
    }
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        Console.Write(Math.Round(((double)sum[i] / matr.GetLength(0)), 1) + "\t");
    }
    System.Console.WriteLine();
}


int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
var mymatrix = GenerateArray(rows, cols);
PrintMatrix(mymatrix);
System.Console.WriteLine();
Average(mymatrix);