// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

PrintArray(array);
FindElement(array);

void FindElement(int[,] array)
{
    Console.WriteLine("введите номер строки искомого элемента: ");
    int rowToFind = int.Parse(Console.ReadLine());
    Console.WriteLine("введите номер столбца искомого элемента: ");
    int columnToFind = int.Parse(Console.ReadLine());
    object element = 0;
    if (rowToFind > rows || columnToFind > columns)
        Console.WriteLine("такого числа нет");
    else
    {
        element = array.GetValue(rowToFind-1, columnToFind-1); //-1
        Console.WriteLine($"искомое число:  {element}");
    }
}
//мой вариант - на входе индексы, на выходе - число, которому индексы соответствуют
//но мне не нравится, что визуально для элемента с индексом 4,5
//выводится число, стоящее на 5 строке в 6 столбце, поэтому добавляю в вывод -1
//если убрать -1, будет выводить элемент по индексу, но для массива с 5 столбцами и 4 строками
//на попытку вывести элемент с индексом (5,4) выдаст ошибку


int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] filledArray)
{
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            Console.Write(filledArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}