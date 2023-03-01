// Задача No34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. *отсортируйте массив методом пузырька


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

// Buble method sort
void BubbleSortArr(int[] resBubleSort)
{
    for(int i = 0; i < resBubleSort.Length; i++)
    {
        for(int a = i + 1; a < resBubleSort.Length; a++)
        {
            if(resBubleSort[i] > resBubleSort[a])
            {
                int arr = resBubleSort[i];
                resBubleSort[i] = resBubleSort[a];
                resBubleSort[a] = arr;
            }
        }
    }
}

// method counts even numbers in sorted array
int numOfEvenNumbers(int [] arr)
{
    int evenNumber = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        // если элемент четный, накапливаем его в переменной evenNumber
        if(arr[i] % 2 == 0)
        evenNumber++;
    }    
    return evenNumber;
}

// create array
int[] testArray = Gen1DArr(10, 100, 999);
// print sorted array
BubbleSortArr(testArray);
// print array
Print1DArr(testArray);

int result = numOfEvenNumbers(testArray);
PrintData("The number of even numbers in the array: ", result);