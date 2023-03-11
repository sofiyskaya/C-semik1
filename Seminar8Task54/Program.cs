// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

// Buble method sort
void BubbleSortArr(int[] resBubleSort)
{
    for(int i = 0; i < resBubleSort.Length; i++)
    {
        for(int a = i + 1; a < resBubleSort.Length; a++)
        {
            if(resBubleSort[i] > resBubleSort[a])
            {
                int arr = resBubleSort[i];
                resBubleSort[i] = resBubleSort[a];
                resBubleSort[a] = arr;
            }
        }
    }
}

// method sorts 2D array 
void Sort2DArr(int[,] arr)
{
    // создание одномерного массива
    int[] row = new int[arr.GetLength(1)];
    // заполняем массив построчно
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        // заполняем массив по столбцам
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            // строку сбрасываем в одномерный массив row
            row[j] = arr[i, j];
        }
        BubbleSortArr(row);
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = row[j];
        }
    }    
}

// create array
int[,] testArray = Gen2DArr(3, 4, 0, 10);
// print array
Print2DArr(testArray);
// print sorted array
Sort2DArr(testArray);
Print2DArr(testArray);