// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

int rowPosition = ReadInt("Vvedite  nomer stroki elementa v massive: ");
int colPosition = ReadInt("Vvedite  nomer stolbtsa elementa v massive: ");


int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempmatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < tempmatrix.GetLength(0); i++)
        for (int j = 0; j < tempmatrix.GetLength(1); j++)
            tempmatrix[i, j] = rand.Next(leftRange, rightRange + 1);

    return tempmatrix;

}

int[,] matrix = GenerateMatrix(5, 7, -9, 9);





int result = GetArrayElement(matrix, rowPosition, colPosition);

if (result != int.MinValue)
{
    Console.WriteLine($"Znachenie elementa: {result}");
}
else
{
    Console.WriteLine("Takogo elementa net v massive");
}

int GetArrayElement(int[,] matrix, int row, int col)
{
    // Проверка наличия строки и столбца в массиве
    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
    {
        // Возвращение значения элемента
        return matrix[row, col];
    }
    else
    {
        // Возвращение значения int.MinValue, чтобы обозначить отсутствие элемента
        return int.MinValue;
    }
}