// Задача No33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
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

// method invers the values of array generated numbers
int SearchElem(int[] arr, int element)
{
    int res = -1;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == element)
        {
            res = i; break;
        }
    }
    return res;
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);

int element = ReadData("Enter the number for research of the array: ");
int resElem = SearchElem(testArr, element);

if(resElem > 0)
{
    Console.WriteLine("Researched element is in the array with the index: " + resElem);
}
else
{
    Console.WriteLine("Researched element is not in the array");
}
