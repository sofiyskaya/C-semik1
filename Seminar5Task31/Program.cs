//  Задача No31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

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


//method collects positive and negative elements of array
(int positive, int negative) NegPosSum(int[] arr)
{
    int positiveSum = 0;
    int negativeSum = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        // если элемент положительный, накапливаем его в переменной positiveSum
        if(arr[i] > 0)
        {
            positiveSum+=arr[i];
        }
        // если элемент отрицательный, накапливаем его в переменной negativeSum
        else
        {
            negativeSum+=arr[i];
        }
    }


    return (positiveSum, negativeSum);
}

// create array
int[] testArr = Gen1DArr(12, -9, 9);
// print array
Print1DArr(testArr);

// 78 и 81 строка замеряют время кода
DateTime d2 = DateTime.Now;
// вызываем метод подсчета, который заполнит пару значений в result
(int positive, int negative) results = NegPosSum(testArr);
Console.WriteLine(DateTime.Now - d2);

// выводим результат
PrintData("Сумма положительных чисел в массиве: ", results.positive);
PrintData("Сумма отрицательных чисел в массиве: ", results.negative);
