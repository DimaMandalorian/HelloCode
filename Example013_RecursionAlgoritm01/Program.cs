﻿// индексы начинаются от 0
// таблица строк,тип данных string
string[,] table = new string [2,5]; //указываем 2 строки, 5 столбцов
// String.Empty
// table [0,0]  table [0,1]  table [0,2] ...table [0,4]
// table [1,0]  table [1,1]  table [1,2] ...table [1,4]






// обращаемся к нужному нам элементу,  table[1,2] = "слово";   обращаемся как к переменной
//указываем наименование массива[индекс строки, индекс столбца]
// используем цикл в цикле, чтобы распечтатать данный массив
// table[1,2] = "слово"; // имя массива table[i строки, i  столбца]
// for (int rows = 0; rows < 2; rows++)  // rows-имя счетчика-(i), rows < 2 количество строк
// {                                     
//     for (int columns = 0; columns < 5; columns++)// цикл для столбцов с количеством 5
//     {
//         Console.WriteLine($"-{table[rows, columns]}-"); // выводим на экран обращаемся к
//     }  //элементам массива [rows, columns]  через имя массива table
// }                    //   [строка, столбец]



// двумерный массив int [,] matrix = new int [3 строки,4 столбца];
//int [,] matrix = new int [3,4];

// методом заполняем таблицу числами
void PrintArray(int[,] matr)
{
    // for (int i = 0; i < 3; i++)  // цикл щелкает строки
    for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) означает количесиво строк
    {                                             // (0) будет означать 3
        //for (int j = 0; j < 4; j++) // цикл щелкает столбцы
        for (int j = 0; j < matr.GetLength(1); j++) // matrix.GetLength(1) это колич. столбцов
        {                                             // (1) это 4 столбца
            Console.Write($"{matr[i,j]} "); // выводим в печать столбцы через пробел 
        }
    Console.WriteLine();  // с новой строки следующую строку
    }                     // получаем прямоугольную таблицу,матрица чисел 3 строки 4 столбца
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1;10) полуинтервал
        }
    }
}

// двумерный массив int [,] matrix = new int [3 строки,4 столбца];
int [,] matrix = new int [3,4];

PrintArray(matrix); //  распечатать таблицу с нулями
FillArray(matrix);  // в качестве аргумента передаем наш массив (matrix)
Console.WriteLine(); // пробел между таблицами
PrintArray(matrix); // распечатать таблицу с числами







// РИСУЕМ И ЗАКРАШИВАЕМ 

// РИСУЕМ
int [,] pic = new int [,] // не обязательно указывать количество строчек и столбцов 
{ //если есть фоксированные данные
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

// ВЫВОДИМ КОНТУР НАРИСОВАННОГО
void PrintImage(int[,] imag) // вывести красиво массив (убрать нули)
{
    for (int i = 0; i < imag.GetLength(0); i++)
    {
        for (int j = 0; j < imag.GetLength(1); j++)
        {
            //Console.Write($"{imag[i,j]} ");  

            if(imag[i,j] == 0) Console.Write($" "); // если [i,j] совпадает с 0 ,
            // тогда на месте 0 печатаем пробел

            else Console.Write($"+"); // если не 0 тогда это 1, и мы на месте 1 печатем +
        }
        Console.WriteLine();
    }
}

// ЗАКРАШИВАЕМ КАРТИНКУ метод закрашивания
void FillImage(int row,int col) //указываем позицию (пиксель) с которой начнем закрашивать X и Y
{
    if(pic[row, col] == 0) // проверяем условие, если пиксель равен 0 (незакрашен)
    {   // тогда мы будем его красить, 
        pic[row, col] = 1; // красим единицей
        FillImage(row - 1, col); // идем в верх
        FillImage(row, col - 1); // затем в лево
        FillImage(row + 1, col); // идем вниз
        FillImage(row, col + 1); // идем в право
    }
}


PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);



// РЕКУРСИЯ 

// РЕКУРСИЯ вычисления факториала
// метод который принимает число, факториял которого надо вычислить
// метод который принимает число и возвращает факториал этого числа 
//int Factorial (int n)
double Factorial (int n) //если данные переполнени меняем тип данных int на double
// для возвращаемого результата
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;// если мы дошли до 1, тогда возвращаем 1
    // иначе возвращаем 
    // текущее значение умножим на факториал предыдущего числа n * Factorial(n - 1);
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial (i)}");
}
Console.WriteLine();



// ЧИСЛА ФИБОНАЧЧИ
// f(1) = 1 первое число
// f(2) = 1 второе число
// f(n) = f(n-1) + f(n-2) для всех следующих чисел
//Числа фибоначчи где каждое сделующее число задается через предыдущее


//int Fibonacci(int n) // int целые числа в качестве аргумента (int n)
double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1; // если (n = 1 или || n = 2) то возвращаем 1
    // иначе возвращаем 
    else return Fibonacci(n - 1) + Fibonacci(n - 2); // f(n - 1) + f(n - 2)
}

for (int i = 1; i < 50; i++) // считаем числа фибоначчи
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}"); // выводим в консоль
}
