// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
System.Random numSintezator = new System.Random();

// Вариант 1
// обращаемся к синтезатору чтобы положить в переменную рандомное число, которое синтезировали
// int rndNumber = numSintezator.Next(10,100);
// Console.WriteLine(rndNumber);
// // определим число старшего разряда (десятки)
// int firstNum = rndNumber / 10;
// // определяем число единиц (остаток от деления на 10)
// int secondNum = rndNumber % 10;
// // сравниваем две цифры
// if (firstNum > secondNum)
// {
//     Console.WriteLine("Первое число - " + firstNum + ", больше второго - " + secondNum);
// }
// else
// {
//     Console.WriteLine(secondNum);
// }

// Вариант 2
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
// в char это символ, который находится в таблице ASCII. ЧТобы преобразовать в int нужно вычесть 48. Так работает только с цифрами.
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[0])-48;

// <переменная> = (условие)?<значение1>:<значение2>;

int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);


