//Напишите программу, которая заполнит спирально массив 4 на 4
Console.Clear();


int [,] CreateSpiralArray(int rows, int columns, int leftRange, int rightRange)
{
    int [,] array = new int [rows, columns]; 
    for (int i = 0; i<rows ; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            array [i,j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int n = EnterNumber("Введите значение n: ");

int [,] matrix = new int [n, n];

void CreateSpiralMatrix (int [,] array)
{
    int index = 1;
    int i = 0;
    int j = 0;
    while (index<= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i,j] = index;
        index++;
        if (i <= j + 1 && i + j < n-1)
        {
            j++;
        }
        else if (i < j && i + j >= n-1)
        {
            i++;
        }
        else if (i >= j && i + j > n-1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}

void ShowArray(int [,] array)
{
    for (int i = 0; i<n ; i++)
    {
        for (int j = 0; j<n; j++)
        {
            if (array[i, j]/10 <= 0)
            {
                Console.Write($"{array[i,j]} ");
            }
            else 
            {
                Console.Write($"{array[i,j]}");
            }
        }
        Console.WriteLine();
    }
}

CreateSpiralMatrix(matrix);
ShowArray(matrix);