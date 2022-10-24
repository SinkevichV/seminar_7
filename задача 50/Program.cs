/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */
Console.WriteLine("Введите значение элемента: ");
int value = int.Parse(Console.ReadLine() ?? "");

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
            newArray[i, j] = rnd.Next(0, 10);
        }
    }
    return newArray;
}
int FindElement(int[,] matrix)
{
      for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == value)
            {
                Console.WriteLine($"Элемент матрицы с индексами ({i};{j}) равен заданному эллементу");
            }
        }

    }
    return value;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int row = GetNumber("Введите количество строк: ");
int column = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitArray(row, column);
PrintMatrix(matrix);
FindElement(matrix);