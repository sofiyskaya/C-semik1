// Задача №39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

// 
void SwapArray(int[] arr)
{
    int bufElem = 0;
    for(int i = 0; i < arr.Length/2; i++)
    {
        bufElem = arr[1];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = bufElem;

    }
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i = 0; i < outArr.Length; i++)
    {
        outArr[i] = arr[arr.Length-1-i];
    }

    return outArr;
}

int[] testArray = Gen1DArr(12, 10, 100);
Print1DArr(testArray);
Console.WriteLine();
SwapArray(testArray);
int[] newArray = SwapNewArray(testArray);
Print1DArr(testArray);
Console.WriteLine();
Print1DArr(newArray);
