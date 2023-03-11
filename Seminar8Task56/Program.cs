// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

// method prints data to user
void PrintData(int msg)
{
    Console.WriteLine(msg);
}

// method researches the row with min sum of elements
int MinRowCount(int[,] arr)
{
    int index = -1;
    int min = int.MaxValue;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        // находим сумму элементов в строке
        int sum = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        // находим минимальную сумму
        if(sum < min)
        {
            min = sum;
            index = i;
        }
    }
    return index;
}

// create array
int[,] testArray = Gen2DArr(3, 4, 0, 10);
// print array
Print2DArr(testArray);
int minSum = MinRowCount(testArray);
PrintData(minSum);
