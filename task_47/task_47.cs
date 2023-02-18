//  Задача 47: Задайте двумерный массив размером m×n, 
//  заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateArray(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11) + Math.Round(rand.NextDouble(), 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int rows = ReadInt(" Введите количество строк матрицы: ");
int cols = ReadInt(" Введите количество столбцов матрицы: ");
System.Console.WriteLine();
double[,] mymatrix = GenerateArray(rows, cols);
PrintMatrix(mymatrix);

