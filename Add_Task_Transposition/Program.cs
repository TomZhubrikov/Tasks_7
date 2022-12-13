// Задана целочисленная матрица, состоящая из N строк и M столбцов. 
// Требуется транспонировать ее относительно горизонтали.

void InputMatrix(int[,] A)
{
    int i, j;
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintMatrix(int[,] A)
{
    int i, j;
    Console.WriteLine("---------------------------------------------");
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"\t{A[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine("---------------------------------------------");
}

void MatrixTransposition(int[,] A) {
    int i, j, c;
    for (i = 0; i < A.GetLength(0) / 2; i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            c = A[i, j];
            A[i, j] = A[A.GetLength(0) - 1 - i, j];
            A[A.GetLength(0) - 1 - i, j] = c;
        }
    }
}

Console.Clear();
Console.WriteLine("Enter a size of matrix [n, m]: ");
Console.Write("n -> ");
int n = int.Parse(Console.ReadLine());
Console.Write("m -> ");
int m = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, m];

InputMatrix(matrix);
PrintMatrix(matrix);
MatrixTransposition(matrix);
PrintMatrix(matrix);
