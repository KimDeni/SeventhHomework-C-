int [,] CreateArr (int n, int m)
{
    return new int [n,m];
}

void FillArr(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }

}

void PrintArr(int [,] arr)
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

void Average (int [,] arr, int row, int col)
{   
    double[] sumArr = new double [col];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < col; j++)
        {
            sumArr[j] = sumArr[j] + arr[i, j];
        }
    }

    for (int i = 0; i < col; i++)
    {
        Console.WriteLine($"{"Cреднее арифметическое"} {i} {"столбца:"} {sumArr[i] / row}");
    }
}
Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateArr(row, col);
FillArr(arr);
PrintArr(arr);
Average(arr, row, col);