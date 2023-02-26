// Задача №29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// * Ввести с клавиатуры длину массива и диапазон значений элементов

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
    int[] arr = new int[len];

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}


// method prints 1D array into console
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

int len = ReadData("Enter the length of the array: ");
int min = ReadData("Enter the minimum number of the array: ");
int max = ReadData("Enter the maximum number of the array: ");

Print1DArr(Gen1DArr(len, min, max));