// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

// Console.WriteLine($"Массив:  [{String.Join(" , ",NewList())}]");

// int[] NewList()
// {
//     int[] list = new int[4];
//     int len  = list.Length;
//     for (int i = 0; i < len; i ++)
//     {
//         list[i] = new Random().Next(100,999);   
//     }
//     return list;
// }



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

//// Первый вариант.
// Console.WriteLine($"Количество четных чисел в списке {NewList()}");

// int NewList()
// {
//     int[] list = new int[4];
//     int len  = list.Length;
//     int count = 0;
//     for (int i = 0; i < len; i ++)
//     {
//         list[i] = new Random().Next(100,999);
//         if(list[i] % 2 == 00)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }

//// Второй Вариант.

// int[] two_list  = {122, 542, 346, 445};
// Console.WriteLine($"Количество четных чисел в списке {Counting_result(two_list)}");

// // int[] test_list = NewList();

// int Counting_result(int[] list)
// {
//     int len = list.Length;
//     int counter = 0;
//     for(int i = 0; i < len; i++)
//     {
//         if(list[i] % 2 == 0)
//         {
//             counter += 1;
//         }
//     }
//     return counter;
// }
 
//  int[] NewList()
// {
//     int[] list = new int[4];
//     int len  = list.Length;
//     for (int i = 0; i < len; i ++)
//     {
//         list[i] = new Random().Next(100,999);   
//     }
//     return list;
// }

