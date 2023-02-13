// Задача 47: Задайте двумерный массив размером
// m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine()!);

void FillArray()
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round((random.NextDouble() * 20 - 10), 1);
            Console.Write("{0, 10}", (array[i, j]).ToString("0.0"));
        }
    Console.WriteLine();
    }
}

FillArray();


