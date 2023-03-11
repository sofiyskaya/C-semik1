// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// method reads data from user
int ReadData(string line)
 {
     Console.Write(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
 }

// method forms 2D array of lines "countRow" and column "countColumn" with random values <-> min & max
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // блок корректировки входных данных(если мин больше макс, меняем их местами)
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    // create class of randomizer
    Random rnd = new Random();
    // return and create array
    int[,] arr = new int[countRow, countColumn];
    // в цикле проходим по всем элементам массива строк
    for(int i = 0; i < countRow; i++)
    {
        // в цикле проходим по всем элементам массива столбцов
        for(int j = 0; j < countColumn; j++)
        {
            // каждый элемент занимаем случайным числом в диапазоне от минимального значения до максимального по строкам и столбцам
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }        
    return arr;
}

 // prints 2D array into console (двумерный)
void Print2DArr(int[,] arr)
{
    // заполняем массив построчно
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        // заполняем массив по столбцам
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int temp = 0;
    int[,] res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            temp = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                temp += matrix1[i, k] * matrix2[k, j];
            }
            res[i, j] = temp;
        }
    }

    return res;
}

// get data from user for martix 1
int row1 = ReadData("Enter a number of rows in first matrix: ");
int column1 = ReadData("Enter a number of columns in first matrix: ");
// get data from user for martix 2
int row2 = ReadData("Enter a number of rows in second matrix: ");
int column2 = ReadData("Enter a number of columns in second matrix: ");
// generate martix 1
int[,] matrix1 = Gen2DArr(row1, column1, 1, 9);
// generate martix 1
int[,] matrix2 = Gen2DArr(row2, column2, 1, 9);
// print matrix 1
Console.WriteLine("Matrix #1: ");
Print2DArr(matrix1);
// print matrix 2
Console.WriteLine("Matrix #2: ");
Print2DArr(matrix2);

// print the result of multiplication of 2 matrix
Console.WriteLine("The multiply matrix: ");
Print2DArr(MultMatrix(matrix1, matrix2));