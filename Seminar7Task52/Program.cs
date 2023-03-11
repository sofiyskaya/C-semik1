// No52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.

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
            arr[i, j] = new Random().Next(min, max);
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

// prints 1D array into console (одномерный)
void Print1DArr(double[] arr)
{
    Console.Write("[");

    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

// method sums values from column and finds the arithmetic means
double[] ColMean2DArr(int[,] arr)
{
    double[] resArr = new double[arr.GetLength(1)];
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            resArr[j] += arr[i, j];
        }
        resArr[j] = resArr[j] / arr.GetLength(0);
    }
    return resArr;
}

// создаем массив, указываем диапазон чисел, заполняемых в строки и столбцы
int[,] arr2D = Gen2DArr(4, 5, 0, 9);
Print2DArr(arr2D);
double[] sumNum = ColMean2DArr(arr2D);
Print1DArr(sumNum);