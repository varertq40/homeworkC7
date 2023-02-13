// Задача 50: Напишите программу, которая на вход
// принимает прозиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указания,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет.

Console.Clear();

int[,] CreateArray(int line, int column, int minValue, int maxValue)
{
    int[,] result = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] MatrixToArray(int[,] matrix)
{
    Console.WriteLine("Введите число, которое необходимо найти ");
    int number = int.Parse(Console.ReadLine()!);
    int count = 0;
    int p = 0;
    int [] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count = matrix[i, j];
            if (count == number)
            {
                p = count;
            } 
        }
    }
    if (p == number)
    {
        Console.WriteLine($"Число {number} есть в массиве.");
    }
    else
    {
        Console.WriteLine($"Числа {number} нет в массиве.");
    }
    return array;
}

Console.WriteLine("Введите кол-во строк ");
int line = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов ");
int column = int.Parse(Console.ReadLine()!);

int[,] matrix = CreateArray(line, column, 0, 10);
PrintArray(matrix);

MatrixToArray(matrix);