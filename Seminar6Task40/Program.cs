// Задача №40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method prints the result of the sum of the array elements 
void PrintData(string res, bool value)
{
    Console.WriteLine(res + value);
}

// метод упрощает подсчет следующего метода
bool Test(int a, int b, int c)
{
    if(a<= b+c)
    {
         return true;
    } 
    else return false;
}

// method checks if triangle with unput values is possible
bool TriangleTest(int a, int b, int c)
{
    bool res = false;
    if(Test(a, b, c) && Test(b, a, c) && Test(c, a, b))
    {
        res = true;
    }
    return res;
}

int sideA = ReadData("Length of side 1: ");
int sideB = ReadData("Length of side 2: ");
int sideC = ReadData("Length of side 3: ");

PrintData("A triangle with such sides can exist: ", TriangleTest(sideA, sideB, sideC));