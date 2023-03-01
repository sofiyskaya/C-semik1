// No38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. 
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом. Для задачи со звездочкой использовать заполнение массива целыми числами.

// method forms 1D array of length "len" with random values <-> min & max
double[] GenArray(int len, int min, int max)
{
    // блок корректировки входных данных(если мин больше макс, меняем их местами)
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    // return and create array
    double[] arr = new double[len];
    // в цикле проходим по всем элементам массива
    for(int i = 0; i < arr.Length; i++)
    {
        // каждый элемент занимаем случайным числом в диапазоне от минимального значения до максимального
        arr[i] = new Random().Next(min, max +1) + (new Random().NextDouble());
        // ввели округление до 4 знаков
        arr[i] = Math.Round(arr[i], 4);
    }
    return arr;
}

// prints 1D array into console (одномерный)
void Print1DArr(double[] arr)
{
    Console.Write("[");

    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

// bubble sort method
void BubbleSortArr(double[] resBubleSort)
{
    for(int i = 0; i < resBubleSort.Length; i++)
    {
        for(int a = i + 1; a < resBubleSort.Length; a++)
        {
            if(resBubleSort[i] > resBubleSort[a])
            {
                double arr = resBubleSort[i];
                resBubleSort[i] = resBubleSort[a];
                resBubleSort[a] = arr;
            }
        }
    }
}

// create array
double[] testArray = GenArray(10, 100, 999);
// print array
Print1DArr(testArray);
// print sorted array
BubbleSortArr(testArray);
// print array
Print1DArr(testArray);

Console.WriteLine(testArray[testArray.Length - 1] - testArray[0]);