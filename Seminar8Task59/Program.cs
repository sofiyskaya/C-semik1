// Задача No59
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

// method converts 2D array
int[,] Update2DArr(int[,]arr, int row, int column)
{
    int[,] res = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0;
    int m = 0;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        m = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(i != row && j != column)
            {
                res[k, m] = arr[i, j];
            }
            if(j != column) m++;
        }
        if(i != row) k++;
    }  
    return res;
}

// method researches min element in 2D array
(int x, int y) MinElem2DArray(int[,] matrix)
{
    int row = 0;
    int collumn = 0;
    int min = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                row = i;
                collumn = j;
            }
        }
    }
    return (row,collumn);
}

int row = ReadData("Введите количество строк ");                                 
int column = ReadData("Введите количество столбцов ");                           
int[,] arr2D = Gen2DArr(row, column, 0, 99);
Print2DArr(arr2D);
Console.WriteLine();
(int x, int y) minElem = MinElem2DArray(arr2D);
int[,] out2DArr = Update2DArr(arr2D, minElem.x, minElem.y);
Print2DArr(out2DArr);