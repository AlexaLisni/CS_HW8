//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


int[,] SortRowWise(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {

            for (int k = 0; k < matr.GetLength(1) - j - 1; k++)
            {
                if (matr[i, k] > matr[i, k + 1])
                {
 
                    int t = matr[i, k];
                    matr[i, k] = m[i, k + 1];
                    matr[i, k + 1] = t;
                }
            }
        }
}  
return matr;
}  
int [,] matrix = CreatMatrixRundInt(4, 4, 1 , 9);
PrintMatrix(matrix);
int [,] sortElement = SortRowWise(matrix);
Console.WriteLine();
PrintMatrix(secondArray);
