// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
    Console.WriteLine("--------------------------------------------------");
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"\t{A[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine("--------------------------------------------------");
}

void FindAverageOfColumn(int[,] A)
{
    int i, j;
    double sum, average = 0;
    for (j = 0; j < A.GetLength(1); j++)
    {
        sum = 0;
        for (i = 0; i < A.GetLength(0); i++)
        {
            sum = sum + A[i, j];
        }
        average = sum / Convert.ToDouble(A.GetLength(0));
        Console.Write($"\t{average}");
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
FindAverageOfColumn(matrix);


