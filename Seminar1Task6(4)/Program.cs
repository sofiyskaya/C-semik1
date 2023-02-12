// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа: ");

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    if(numberA > numberC)
    {
        Console.WriteLine("Наибольшее число: " + numberA);
    }
    else 
    {
        Console.WriteLine("Наибольшее число: " + numberC);
    }
}
else
{
    if(numberB > numberC)
    {
        Console.WriteLine("Наибольшее число: " + numberB);
    }
    else
    {
        Console.WriteLine("Наибольшее число: " + numberC);
    }
}