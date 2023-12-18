// Задача 2: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempmatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < tempmatrix.GetLength(0); i++)
        for (int j = 0; j < tempmatrix.GetLength(1); j++)
            tempmatrix[i, j] = rand.Next(leftRange, rightRange + 1);

    return tempmatrix;

}

int[,] matrix = GenerateMatrix(5, 5, -9, 9);

void SwapFirstAndLastRows(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    // Проверка, что в массиве есть хотя бы две строки
    if (rowCount >= 2)
    {
        // Меняем местами первую и последнюю строки
        for (int j = 0; j < colCount; j++)
        {
            int temp = matrix[0, j];
            matrix[0, j] = matrix[rowCount - 1, j];
            matrix[rowCount - 1, j] = temp;
        }
    }
    else
    {
        Console.WriteLine("Недостаточно строк для обмена");
    }
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");

        }
        System.Console.WriteLine();
    }
}

Console.WriteLine("Ishodniy massiv:");
PrintMatrix(matrix);

SwapFirstAndLastRows(matrix);

Console.WriteLine("Massiv posle obmena:");
PrintMatrix(matrix);