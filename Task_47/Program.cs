// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void InputMatrix(double[,] A)
{
    int i, j;
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().NextDouble();
        }
    }
}

void PrintMatrix(double[,] A)
{
    int i, j;
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"{A[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Enter a size of matrix [n, m]: ");
Console.Write("n -> ");
int n = int.Parse(Console.ReadLine());
Console.Write("m -> ");
int m = int.Parse(Console.ReadLine());
double[,] matrix = new double[n, m];

InputMatrix(matrix);
PrintMatrix(matrix);