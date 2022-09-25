// Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] finalArray = new int[rows, columns];

Console.WriteLine();
Console.WriteLine("Матрица 1: ");
CreateArray(array);
PrintArray (array);

Console.WriteLine("Матрица 2: ");

CreateArray(secondArray);
PrintArray (secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Перемножить невозможно! ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        finalArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            finalArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

Console.WriteLine("Произведение матриц: ");
PrintArray (finalArray);

int ReadInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}