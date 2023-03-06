// No41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method prints the result of the sum of the array elements 
void PrintData(string res)
{
    Console.WriteLine(res);
}

// method counts the positive numbers
int CountNum(int numM)
{
    int res = 0;
    for(int i = 0; i < numM; i++)
    {
        if(ReadData(" ") > 0)
        {
            res++;
        }
    }
    return res;
}

int numM = ReadData("Enter the numbers: ");

PrintData("The number of positive numbers: " + CountNum(numM));