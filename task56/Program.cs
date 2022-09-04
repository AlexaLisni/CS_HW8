// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] CreatMatrixRundInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }

    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
            
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 3},");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine("]");
    }
}
void SmallestSum(int[,] matr)
{
    int sum = int.MaxValue;

    int row = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
    int temp = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
         {
            temp += matr[i, j];
        }
         if (temp < sum)
          {
            sum = temp;
            row = i;
          }
     }
            Console.WriteLine($"Строка: {row} Сумма {sum}");

}
int [,] matrix = CreatMatrixRundInt(5, 4, 1 , 9);
PrintMatrix(matrix);
SmallestSum(matrix);

