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
            arr[i,j] = new Random().Next(1,100);
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

void ShowIndex(int [,] arr, int ri, int ci){
    if(ri <= arr.GetLength(0) && ci < arr.GetLength(1)){
        Console.WriteLine($"{"Выбранный Вами элемент:"} {arr[ri - 1,ci - 1]}");
    }else{
         Console.WriteLine("По данной позиции нет элемента");
    }
}

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());



int[,] arr = CreateArr(row, col);
FillArr(arr);
PrintArr(arr);
Console.WriteLine("На какой строке находится элемент: ");
int rowindex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В каком столбце находится элемент: ");
int colindex = Convert.ToInt32(Console.ReadLine());


ShowIndex(arr, rowindex, colindex);
