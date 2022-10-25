// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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

    int[,] tableArray = CreateRandomArray();
    PrintArray(tableArray);
    Console.Write("Введите номер строки, начиная с 1: ");
    int tableRow = int.Parse(Console.ReadLine());
    Console.Write("Введите номер колонки, начиная с 1: ");
    int tableColumn = int.Parse(Console.ReadLine());

    bool existRowCol = true;
    if (tableRow < 1 || tableRow > tableArray.GetLength(0))
    {
        Console.WriteLine($"В таблице отсутствует строка № {tableRow}");
        existRowCol = false;
    }
    if (tableColumn < 1 || tableColumn > tableArray.GetLength(1))
    {
        Console.WriteLine($"В таблице отсутствует колонка № {tableColumn}");
        existRowCol = false;
    }
    if (existRowCol)
        Console.WriteLine($"Значение таблицы({tableRow},{tableColumn}) = {tableArray[tableRow-1,tableColumn-1]}. (Примечание: Таблица для удобства пользователя нумеруется с 1, а не с 0)");
