// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, columns];

Console.WriteLine();

CreateArray(array);
PrintArray(array);

int MinSumma = 0;
int index = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int summa = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        summa += array [i,j];
    }
    if (i == 0)
    {
        MinSumma = summa;
    }
    else if (summa < MinSumma)
    {
        MinSumma = summa;
        index = i;
    }
}

Console.WriteLine($"Наименьшая сумма элементов в строке № {index + 1}. Сумма элементов в ней = {MinSumma}");

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