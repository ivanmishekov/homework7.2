// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 - > 1


int InputInt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}


int[,] CreateNumbersArray()
{
    Random rnd = new Random();
    int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("|" + array[i, j] + "|    ");
        }
    }
    Console.WriteLine();
}


int[,] numb = CreateNumbersArray();
PrintArray(numb);
int row = InputInt("Введите индекс строки");
int column = InputInt("Введите индекс столбца");

if (row < numb.GetLength(0) && column < numb.GetLength(1))
{
    Console.WriteLine(numb[row, column]);
}
else
{
    Console.WriteLine($"Числа на позициях [{row}, {column}] в массиве нет!");
}
