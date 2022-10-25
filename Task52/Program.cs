// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandomArray()
{
    Random rnd = new Random();
    int[,] resultArray = new int[rnd.Next(2,11), rnd.Next(2,11)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i,j] = rnd.Next(1,10); // от 1 до 9
        }
    }
    return resultArray;
}


 void PrintArray(int[,] array)
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

 void FindAverageColumnsOfArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double averageColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            averageColumn = averageColumn + array[i,j];
        averageColumn = Math.Round(averageColumn / array.GetLength(0), 1); 
        Console.Write($"{averageColumn} ");
    }
}

    int[,] tableArray = CreateRandomArray();
    Console.Clear();
    Console.WriteLine("Исходная таблица:");
    PrintArray(tableArray);
    Console.WriteLine("\nСреднее по колонкам:");
    FindAverageColumnsOfArray(tableArray);
    Console.WriteLine("\n");
