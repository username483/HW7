// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine());


double[,] matrix = new double[m, n];

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 это количество строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 это количество столбцов
        {
            Console.Write("{0,6:F1}", matrix[i, j]);// "{0,6:F1}" это форматирование выводимых чисел F1 - один знак послезапятой, F2 - 2 знака и т д
        }                                           // 0,6 это расстояние между выводимыми символами
        Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble()*10;// функция NextDouble() возвращает числа от 0 до 1
                                                      // чтобы получить числа от 0 до 10, нужно умножить на 10
            
        }
    }
}
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);