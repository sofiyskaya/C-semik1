// Задача No49
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
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

int[,] Update2DArr(int[,] arr, int countRow, int countColumn)
{
    // в цикле проходим по всем четным элементам массива строк (i + 2)
    for(int i = 0; i < countRow; i++)
    {
        // в цикле проходим по всем четным элементам массива столбцов (j + 2)
        for(int j = 0; j < countColumn; j++)
        {
            if((i % 2 == 0) && (j % 2 == 0))
            {
                // возводим число в массиве во вторую степень
            arr[i, j] = arr[i, j] * arr[i, j];
            }
        }
    }  
    return arr;      
}


// вводим количество строк и столбцов
int row = ReadData("Enter the number of lines: ");
int column = ReadData("Enter the number of column: ");
// создаем массив, указываем диапазон чисел, заполняемых рандомно в строки и столбцы
int[,] arr2D = Gen2DArr(row, column, 0, 9);
// печатаем массив
Print2DArr(arr2D);
int[,] resArr = Update2DArr(arr2D, row, column);
Print2DArr(resArr);