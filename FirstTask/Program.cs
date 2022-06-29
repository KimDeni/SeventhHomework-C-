double [,] CreateArr (int n, int m)
{
    return new double [n,m];
}

void FillArr(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = (new Random().NextDouble()) * (new Random().Next(-10, 11));
        }
    }

}

void PrintArr(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
                for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }

}

int row = Convert.ToInt32(Console.ReadLine());
int col = Convert.ToInt32(Console.ReadLine());

double[,] arr = CreateArr(row, col);
FillArr(arr);
PrintArr(arr);
