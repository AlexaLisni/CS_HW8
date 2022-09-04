// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

         int m = 2, n = 2, p = 2, q = 2;
         int i, j;
         int[,] a = {{2, 4 }, {3, 2}};
         int[,] b = {{3, 4}, {3, 3},};
         Console.WriteLine("матрицa a:");
         for ( i = 0; i < m; i++)
          {
            for (j = 0; j < n; j++)
            {
               Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
         }


         Console.WriteLine("матрицa b:");
         for (i = 0; i < p; i++) 
         {
            for (j = 0; j < q; j++)
            {
               Console.Write(b[i, j] + " ");
            }
            Console.WriteLine();
         }

            int[,] c = new int[m, q];


            for (i = 0; i < m; i++)
             {
            for (j = 0; j < q; j++) 
                {
                c[i, j] = 0;
            for (int k = 0; k < n; k++)
                {
                c[i, j] += a[i, k] * b[k, j];
                }
                }
                }
            Console.WriteLine("произведение двух матриц :");
            for (i = 0; i < m; i++)
            {
               for (j = 0; j < n; j++)
            {
                Console.Write(c[i, j]+" ");
            }
               Console.WriteLine();
            }
         
      
   
