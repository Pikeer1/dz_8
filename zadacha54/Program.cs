// Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, columns];

CreateArray(array);
Console.WriteLine("Изначальный массив: ");
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int y = 0; y < array.GetLength(1) - 1; y++)
        {
            if (array [i, y] < array [i, y + 1])
            {
                int count = 0;
                count = array [i, y];
                array [i, y] = array [i, y + 1];
                array [i, y + 1] = count;
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("Упорядоченный массив: ");
PrintArray(array);

void CreateArray(int [,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers [i, j] = new Random().Next(1 , 11);
        }
    }
}

void PrintArray(int [,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine();
    }
}