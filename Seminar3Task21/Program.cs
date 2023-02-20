// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine()??"0");
}
// метод выводит данные пользователю
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}

// метод находит расстояние между точками на плоскости
double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
}

int x1 = ReadData("Введите координату х точки А:");
int y1 = ReadData("Введите координату y точки А:");
int z1 = ReadData("Введите координату z точки A:");
int x2 = ReadData("Введите координату x точки B:");
int y2 = ReadData("Введите координату y точки B:");
int z2 = ReadData("Введите координату z точки B:");


double res = CalcLen(x1, x2, y1, y2, z1, z2);

PrintData("Расстояние между точками А и В: ", res);