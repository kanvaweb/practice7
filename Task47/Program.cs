// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int rows, int columns)
{
    double[,] resultArray = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i,j] = Math.Round(rnd.NextDouble()*20-10, 1);  // От -9 до 9
        }
    }
    return resultArray;
}


 void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

    Console.Write("Введите сколько строк будет в таблице (m): ");
    int tableRows = int.Parse(Console.ReadLine());
    Console.Write("Введите сколько колонок будет в таблице (n): ");
    int tableColumns = int.Parse(Console.ReadLine());
    double[,] tableArray = CreateArray(tableRows, tableColumns);
    PrintArray(tableArray);