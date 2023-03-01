// Задача №45 Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method prints the result of the sum of the array elements 
void PrintData(string result)
{
    Console.WriteLine(result);
}

// method forms 1D array of length "len" with random values <-> min & max
int[] Gen1DArr(int len, int min, int max)
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
    int[] arr = new int[len];
    // в цикле проходим по всем элементам массива
    for(int i = 0; i < arr.Length; i++)
    {
        // каждый элемент занимаем случайным числом в диапазоне от минимального значения до максимального
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

// prints 1D array into console (одномерный)
void Print1DArr(int[] arr)
{
    Console.Write("[");

    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}


int[] CopyArrayStandartTools(int[] inputArr)
{
    int[] outArr = new int[inputArr.Length];
    inputArr.CopyTo(outArr, 0);
    return outArr;
}

int[] testArr = Gen1DArr(40, 1, 50);
Print1DArr(testArr);
int[] testArrNew = CopyArrayStandartTools(testArr);
Print1DArr(testArrNew);