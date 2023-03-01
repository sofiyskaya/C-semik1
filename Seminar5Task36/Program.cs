// Задача No36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

// method prints the result of the sum of the array elements 
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

// method accumulates sum of elements with odd index
int OddSum(int[] arr)
{
    int res = 0;
    for(int i = 1; i < arr.Length; i = i + 2)
    {
        res = res + arr[i];
    }
    return res;
}

// create array
int[] testArray = Gen1DArr(10, 5, 99);
// print array
Print1DArr(testArray);

int result = OddSum(testArray);
PrintData("The sum of numbers in the array: ", result);