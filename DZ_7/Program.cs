// // Задача 47:


// Console.WriteLine("Введите кол-во строк");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите кол-во столбцов");
// int n = int.Parse(Console.ReadLine()!);
// PrintArray(NewList(m, n));


// //---------------------------Методы -----------------------

//int[,]  NewList(int line, int vertical)      // Создает двумерный массив, заполненный вещественными числами, с указанным кол-вом строк и линий
// {   
//    int[,] list = newint[line, vertical];
//     for (int i = 0; i < line; i++)
//     {   
//         for(int j = 0; j < vertical; j ++)
//         {
//             list[i, j] = new Random().Next(-100,100) / 10;
//         }
//     }
//     return list;
// }

// void PrintArray(intint[,] array)               // Выводит в консоль двумерный массив
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// Задача 50:
// int a1 = new Random().Next(1,10);
// int b1 = new Random().Next(1,10);
// int[,] list = NewList(a1, b1);
// PrintArray(list);
// int a = new Random().Next(1,10);
// int b = new Random().Next(1,10);
// Console.WriteLine($"Число с индексом {a} и {b}");
// SearchByIndex(list, a, b);


// //---------------------------Методы -----------------------

// int[,]  NewList(int line, int vertical)      // Создает двумерный массив, заполненный целыми числами, с указанным кол-вом строк и линий
// {   
//     int[,] list = new int[line, vertical];
//     for (int i = 0; i < line; i++)
//     {   
//         for(int j = 0; j < vertical; j ++)
//         {
//             list[i, j] = new Random().Next(0,9);
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
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// void SearchByIndex(int[,] array, int line, int vertical)
// {
//     int counter = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == line && j == vertical)
//             {
//                 counter += 1;
//             }
//         }
//     }
//     if (counter > 0){Console.WriteLine(list[line, vertical]);}
//     else{Console.WriteLine("такого числа нет");}
// }



////Задача 52

// int[,] list = NewList();
// Console.WriteLine($"Суммой чисел каждого стобца списка :");
// PrintArray(list);
// Console.WriteLine();
// Console.WriteLine($"Будет [{String.Join(" , ", ArithmeticMean(list))}]");

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

// double[]  ArithmeticMean(int[,] list)     // Находит среднее арифметичское каждого столбца двухмерного массива
// {   
//     double[]  arithmetic= new double[list.GetLength(1)];
//     for(int i = 0; i < list.GetLength(1); i++)
//     {
//         for(int j = 0; j < list.GetLength(0); j ++)
//         {
//             arithmetic[i] += list[j, i];
//         }
//     arithmetic[i] = Math.Round(arithmetic[i] / (list.GetLength(0)), 2);
//     }

//     return arithmetic ;
// }