// 50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. 
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// FEBONACCI NUMBER GENERATION METHOD
int [] FibNum(int num)
{
    int [] res = new int [num];
    int first = 0;
    int last = 1;

    res[0] = 0;
    res[1] = 1;

    for(int i = 2; i < num; i++)
    {
        res [i]= first + last;
        (first, last) = (last, first + last);
    }
    return res;
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

    // form 1D array of Fibonacci numbers
    int[] fibNumArr = FibNum(countRow * countColumn);
    // return and create array
    int[,] arr = new int[countRow, countColumn];

    int num = 0;
    // в цикле проходим по всем элементам массива строк
    for(int i = 0; i < countRow; i++)
    {
        // в цикле проходим по всем элементам массива столбцов
        for(int j = 0; j < countColumn; j++)
        {
            // каждый элемент занимаем числом Фибоначчи по строкам и столбцам
            arr[i, j] = fibNumArr[num];
            num++;
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

//method research number in array 
void FindNumArray(int[,] array, int FindNum)
{   //переменная для индикации нашли мы число в массиве или нет
    int num = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == FindNum)
            {
                num = 1;
                // если нашли число, красим зеленым 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{array[i, j]}\t");
                Console.ResetColor();
            }
            else
            {
                Console.Write($"{array[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
    if (num == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Number is not found");
        Console.ResetColor();
    }


}

// вводим количество строк и столбцов
int row = ReadData("Enter the number of lines: ");
int column = ReadData("Enter the number of column: ");
// создаем массив, указываем диапазон чисел, заполняемых рандомно в строки и столбцы
int[,] arr2D = Gen2DArr(row, column, 0, 9);
Console.WriteLine("Initial array:");
Print2DArr(arr2D);

int resNum = ReadData("Enter the number for research:");
Console.WriteLine();
FindNumArray(arr2D, resNum);