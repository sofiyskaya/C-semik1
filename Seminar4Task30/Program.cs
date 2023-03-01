// Задача No30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// method forms 1D array of length "len" with random values <-> min & max
int[] Gen1DArr(int len, int min, int max)
{
    int[] arr = new int[len];

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}


// prints 1D array into console
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

Print1DArr(Gen1DArr(8, 0, 1));