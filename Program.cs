/*Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

// int[,] Create2drandomArray()
// {
//     Console.WriteLine("Please input a number of row ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Please input a number of columns ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Please input a number of minvalue ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Please input a number of maxvalue ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void SortDescending(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = j; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int memory = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = memory;
//                 }
//             }
//         }
//     }
// }

// int[,] array = Create2drandomArray();
// Show2dArray(array);
// SortDescending(array);
// Show2dArray(array);

/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов.*/

// int[,] Create2drandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int sumOfRows(int[,] array, int i)
// {
//     int sumRow = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sumRow += array[i, j];
//     }
//     return sumRow;
// }
// Console.WriteLine("Please input a number of row ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input a number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input a number of minvalue ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input a number of maxvalue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// if (rows % 2 == 0 && columns % 2 == 0)
// {
//     int[,] array = Create2drandomArray(rows, columns, minValue, maxValue);
//     Show2dArray(array);
//     int minSum = 0;
//     int sumRow = sumOfRows(array, 0);
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int MemorySum = sumOfRows(array, i);
//         if (sumRow > MemorySum)
//         {
//             sumRow = MemorySum;
//             minSum = i;
//         }
//     }
//     Console.WriteLine($"{minSum + 1} row with minimal sum {sumRow} of elements ");
// }
// else { Console.WriteLine("Please input an even number "); }

/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

// int[,] Create2drandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// int columnsRowReplacer(int row, int column)
// {
//     int memory = column;
//     column = row;
//     row = memory;
//     return row;
// }

// int rowColumnsReplacer(int row, int column)
// {
//     int memory = row;
//     row = column;
//     column = memory;
//     return column;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void matrixMultiplication(int[,] firsMatrix, int[,] secMatrix, int[,] multiResult)
// {
//     for (int i = 0; i < multiResult.GetLength(0); i++)
//     {
//         for (int j = 0; j < multiResult.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < firsMatrix.GetLength(1); k++)
//             {
//                 sum += firsMatrix[i, k] * secMatrix[k, j];
//             }
//             multiResult[i, j] = sum;
//         }
//     }
// }

// Console.WriteLine("Please input a number of row ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input a number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input a number of minvalue ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input a number of maxvalue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

// void create3dArray(int[,,] array)
// {
//     int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
//     int num;
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);
//         num = temp[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 100);
//                     j = 0;
//                     num = temp[i];
//                 }
//                 num = temp[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array.GetLength(0); x++)
//     {
//         for (int y = 0; y < array.GetLength(1); y++)
//         {
//             for (int z = 0; z < array.GetLength(2); z++)
//             {
//                 array[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }
// void Show3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"row({i + 1}) column({j + 1}) ");
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"layer({k + 1})={array[i, j, k]}; ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Please input a number of rows ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input a number of columns ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input a number of layers ");
// int layer = Convert.ToInt32(Console.ReadLine());
// int[,,] array3d = new int[row, column, layer];
// create3dArray(array3d);
// Console.WriteLine("3D array with non-repeating 2-digit integers is ");
// Console.WriteLine();
// Show3dArray(array3d);

// int[,] firstMatrix = Create2drandomArray(rows, columns, minValue, maxValue);
// Console.WriteLine("First matrix is");
// Show2dArray(firstMatrix);
// int secRow = columnsRowReplacer(rows, columns);
// int secColumn = rowColumnsReplacer(rows, columns);
// int[,] secondMatrix = Create2drandomArray(secRow, secColumn, minValue, maxValue);
// Console.WriteLine("Second matrix is");
// Show2dArray(secondMatrix);
// int[,] multiplyResultMatrix = new int[rows, secColumn];
// matrixMultiplication(firstMatrix, secondMatrix, multiplyResultMatrix);
// Console.WriteLine("Result of multiplcation of matrix is ");
// Show2dArray(multiplyResultMatrix);


/*Напишите программу, которая заполнит спирально массив 4 на 4.*/

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Please input a size of array ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] Matrix = new int[n, n];

// int memory = 1;
// int i = 0;
// int j = 0;

// while (memory <= Matrix.GetLength(0) * Matrix.GetLength(1))
// {
//     Matrix[i, j] = memory;
//     memory++;
//     if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
//         j++;
//     else if (i < j && i + j >= Matrix.GetLength(0) - 1)
//         i++;
//     else if (i >= j && i + j > Matrix.GetLength(1) - 1)
//         j--;
//     else
//         i--;
// }

// Show2dArray(Matrix);