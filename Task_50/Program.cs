// Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет

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
int[,] matrix = new int[n, m];

InputMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine("Enter a number string and number column for get value of element: ");
Console.Write("i -> ");
int i = int.Parse(Console.ReadLine());
Console.Write("j -> ");
int j = int.Parse(Console.ReadLine());

if (i > 0
    && i < n
    && j > 0
    && j < m)
{
    Console.WriteLine($"{matrix[i, j]}");
}
else 
{
    Console.WriteLine("Element is not found!");
}
