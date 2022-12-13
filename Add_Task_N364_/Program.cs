// Даны числа n и m. Создайте массив A[n][m] и заполниье его, 
// как показано на примере.

void PrintMatrix(int[,] A)
{
    int i, j;
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            Console.Write($"\t{A[i, j]} ");
        }
        Console.WriteLine();
    }
}

void InputMatrix(int[,] A)
{
    int i = 0, j = 0, num = 0, d = 0;
    while (d < A.GetLength(1))
    {
        i = 0;
        j = d;
        while (i < A.GetLength(0) && j >= 0)
        {
            A[i, j] = num;
            i++;
            j--;
            num++;
            }
        d++;
    }
    d = 1;
    while (d < A.GetLength(0))
    {
        i = d;
        j = A.GetLength(1) - 1;
        while (i < A.GetLength(0) && j >= 0)
        {
            A[i, j] = num;
            i++;
            j--;
            num++;
            }
        d++;
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
