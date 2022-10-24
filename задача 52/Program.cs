/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */



int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число. Повторите ввод.");

    return result;
}

int[,] InitArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = rnd.Next(2, 10);
        }
    }
    return newArray;
}

void GetArithmeticMean(int[,] matrix) 
{
    double summ = 0;
    for (int i = 0; i < matrix.GetLength(1); i++) // линия
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(0); j++) // столбик
        {
            count += matrix[j, i];
        }
        summ = Convert.ToDouble( count) / Convert.ToDouble( matrix.GetLength(0));
        Console.WriteLine($"среднее арифметическое столбца {i+1} равно:{Math.Round(summ, 2)} ");
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.Write("\r\n");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.Write("\r\n");
}

int row = GetNumber("Введите колличество строк: ");
int column = GetNumber("Введите колличество столбцов: ");
int[,] matrix = InitArray(row, column);
PrintMatrix(matrix);
GetArithmeticMean(matrix);