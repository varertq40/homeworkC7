// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] CreateInArray(int line, int column, int minValue, int maxValeu)
{
    int[,] result = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValeu);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] SumColumn(int[,] arraySum)
{
    double[] result = new double[arraySum.GetLength(1)];
    for (int i = 0; i < arraySum.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arraySum.GetLength(0); j++)
        {
            sum += arraySum[j, i];
        }
    sum /= arraySum.GetLength(0);
    result[i] = sum;
    }
    return result;
}

Console.Write("Введите кол-во строк ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов ");
int column = int.Parse(Console.ReadLine()!);

int[,] array = CreateInArray(line, column, 0, 10);
PrintArray(array);
double[] result = SumColumn(array);
Console.WriteLine($"Среднее арифметическое каждого столбца {String.Join(", ", result)}");