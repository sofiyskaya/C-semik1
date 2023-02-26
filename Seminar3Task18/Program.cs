// Задача №18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void SearchXY(int num)
{
    if(num > 0 && num < 5)
    {
        if(num == 1) Console.WriteLine("x > 0, y > 0");
        if(num == 2) Console.WriteLine("x > 0, y < 0");
        if(num == 3) Console.WriteLine("x < 0, y < 0");
        if(num == 4) Console.WriteLine("x < 0, y > 0");
    }
    else Console.WriteLine("Вы ввели не номер четверти");
}


int quarter = ReadData("Введите номер четверти: ");
SearchXY(quarter);
