// Задача No48
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// method forms 2D array of lines "countRow" and column "countColumn" 
int[,] Gen2DArr(int countRow, int countColumn)
{
    // return and create array
    int[,] resArr = new int[countRow, countColumn];
    // в цикле проходим по всем элементам массива строк
    for(int i = 0; i < countRow; i++)
    {
        // в цикле проходим по всем элементам массива столбцов
        for(int j = 0; j < countColumn; j++)
        {
            // каждый элемент занимаем случайным числом в диапазоне от минимального значения до максимального по строкам и столбцам
            resArr[i, j] = i + j;
        }
    }        
    return resArr;
}

// prints 2D array into console (двумерный)
void Print2DArr(int[,] arr)
{
    // красим числа в разные рандомные цвета
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue};
    // заполняем массив построчно
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        // заполняем массив по столбцам
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 5)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// создаем массив, указываем диапазон чисел, заполняемых в строки и столбцы
int[,] arr2D = Gen2DArr(8, 5);
// печатаем массив
Print2DArr(arr2D);