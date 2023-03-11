// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// method reads data from user
int ReadData(string line)
 {
     Console.Write(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
 }

// method forms 3D array of lines "countRow", column "countColumn", lists "countList" with random values <-> min & max
int[,,] Gen3DArr(int countRow, int countColumn, int countList, int min, int max)
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
    int[,,] arr = new int[countRow, countColumn, countList];
    // в цикле проходим по всем элементам массива строк
    for(int i = 0; i < countRow; i++)
    {
        // в цикле проходим по всем элементам массива столбцов
        for(int j = 0; j < countColumn; j++)
        {
            // в цикле проходим по всем элементам массива листов
            for(int k = 0; k < countList; k++)
            {
                // каждый элемент занимаем случайным числом в диапазоне от минимального значения до максимального по строкам, столбцам и листам
                arr[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }        
    return arr;
}

 // prints 3D array into console (трехмерный)
void Print3DArr(int[,,] arr)
{
    // заполняем массив построчно
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        // заполняем массив по столбцам
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            // заполняем массив по листам
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}\t");
            }
        }
        Console.WriteLine();
    }
}

// get data from user
int row = ReadData("Enter a number of rows: ");
int column = ReadData("Enter a number of columns: ");
int list = ReadData("Enter a number of lists: ");

// generate 3D array
int[,,] testArr = Gen3DArr(row, column, list, 1, 99);

// print 3D array
Print3DArr(testArr);