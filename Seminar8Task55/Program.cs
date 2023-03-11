// Задача No55
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

// метод развернет матрицу
void TranspArr(int[,] arr)
{
    int temp = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = i + 1; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}

int rowNum = ReadData("Enter a number of rows:    ");
int colNum = ReadData("Enter a number of columns: ");
Console.WriteLine();

int[,] testArr = Gen2DArr(rowNum, colNum, 10, 99);
Print2DArr(testArr);
if (testArr.GetLength(0) == testArr.GetLength(1))
{
    TranspArr(testArr);
    Print2DArr(testArr);
}
else
{
    Console.WriteLine("The matrix is not square!");
}
Console.WriteLine(); 