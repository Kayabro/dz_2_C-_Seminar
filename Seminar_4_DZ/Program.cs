// Задача № 25 напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 

// Console.WriteLine("Введите число А которое возведем в степень числа B :");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine();
// Console.WriteLine("Введите число B :");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine();
// Console.WriteLine($"А в Степени В будет равно {PowAInB(a, b)}");

// int PowAInB(int one, int two)
// {   
//     int c = one;
//     for(int i = 1; i < two; i++)
//     {
//         one = one * c;
//     }
//     return one;
// }




// // Здача №27.

// Console.WriteLine("Введите число, посчитаем сумму его цифр :");
// string number = Console.ReadLine()!;
// Console.WriteLine();
// Console.WriteLine($"Сумма чисел числа {number}, равна {SumNum(number)}");

// int SumNum(string num)
// {
//     int len =  number.Length;
//     int result = 0;
//     int a = 0;
    
//     for (int i = 0; i < len; i ++)
//     {
//         a = Convert.ToInt32(Convert.ToString(num[i]));
//         result += a;
//     }
//     return result;
// }


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

// Console.WriteLine($"Массив:  [{String.Join(" , ",NewList())}]");

// int[] NewList()
// {
//     int[] list = new int[8];
//     int len  = list.Length;
//     for (int i = 0; i < len; i ++)
//     {
//         list[i] = new Random().Next(1,9);   
//     }
//     return list;
// }