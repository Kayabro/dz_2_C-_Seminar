// // Задача 54 :

// int[,] array = NewList();
// Console.WriteLine("Список :");
// PrintArray(array);
// Console.WriteLine("ОТсортированный список :");
// SortToLower(array);
// PrintArray(array);

// //---------------------------Методы -----------------------

// int[,]  NewList()      // Создает двумерный массив, заполненный числами.
// {   
//     int line = new Random().Next(3, 9);
//     int vertical = new Random().Next(3, 9);
//     int[,] list = new int[line, vertical];
//     for (int i = 0; i < line; i++)
//     {   
//         for(int j = 0; j < vertical; j ++)
//         {
//             list[i, j] = new Random().Next(1, 9) ;
//         }
//     }
//     return list;
// }

// void PrintArray(int[,] array)               // Выводит в консоль  массив
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + ", ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// void SortToLower(int[,] array)             // Функция сортировки элементов в строке двумерного массива, по убыванию
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }


// // Задача 56:

// int[,] array = NewList();
// PrintArray(array);
// Console.WriteLine($"Строка с наименьшей суммой элементов : {FindSmallLine(array)}");


// //---------------------------Методы -----------------------


// int[,]  NewList()      // Создает двумерный массив, заполненный числами.
// {   
//     int line = new Random().Next(4, 6);
//     int vertical = new Random().Next(2, 4);
//     int[,] list = new int[line, vertical];
//     for (int i = 0; i < line; i++)
//     {   
//         for(int j = 0; j < vertical; j ++)
//         {
//             list[i, j] = new Random().Next(1, 9) ;
//         }
//     }
//     return list;
// }

// void PrintArray(int[,] array)               // Выводит в консоль  массив
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + ", ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }



// int FindSmallLine (int[,] list)    // находит строку с  минимальной суммой элементов.
// {
//     int minSum = 0;
//     int sumNow = 0;
//     int counter = 0;
//     for (int i = 0; i < list.GetLength(0); i++)  
//     {
//         for (int j = 0; j < list.GetLength(1); j++)
//         {
//             sumNow += list[i, j];   
//         }
//         if(sumNow < minSum || minSum == 0)
//         {
//         minSum = sumNow;
//         sumNow = 0;
//         counter += 1;
//         }
//     }
//     return counter;
// }
