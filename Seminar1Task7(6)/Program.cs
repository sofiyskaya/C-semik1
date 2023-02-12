// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");

int numEven = Convert.ToInt32(Console.ReadLine());

if(numEven % 2 == 0)
{
    Console.WriteLine("Число " + numEven + " - является четным");
}
else
{
    Console.WriteLine("Число " + numEven + " - является нечетным");
}