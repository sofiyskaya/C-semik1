// No47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method forms 2D array of lines "countRow" and column "countColumn" with random values <-> min & max
double[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // блок корректировки входных данных(если мин больше макс, меняем их местами)
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    // create class of randomizer
    // Random rnd = new Random();
    // return and create array
    double[,] arr = new double[countRow, countColumn];
    // в цикле проходим по всем элементам массива строк
    for(int i = 0; i < countRow; i++)
    {
        // в цикле проходим по всем элементам массива столбцов
        for(int j = 0; j < countColumn; j++)
        {
            // каждый элемент занимаем случайным числом в диапазоне от минимального значения до максимального по строкам и столбцам
            arr[i, j] = new Random().Next(min, max) + new Random().NextDouble();
            // ввели округление до 2 знаков
            arr[i, j] = Math.Round(arr[i, j], 2);
        }
    }        
    return arr;
}

// prints 2D array into console (двумерный)
void Print2DArr(double[,] arr)
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

// вводим количество строк и столбцов
int row = ReadData("Enter the number of lines: ");
int column = ReadData("Enter the number of column: ");
// создаем массив, указываем диапазон чисел, заполняемых рандомно в строки и столбцы
double[,] arr2D = Gen2DArr(row, column, 10, 99);
// печатаем массив
Print2DArr(arr2D);
