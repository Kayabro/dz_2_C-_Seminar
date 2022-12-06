// // Задача 47:


// Console.WriteLine("Введите кол-во строк");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите кол-во столбцов");
// int n = int.Parse(Console.ReadLine()!);
// PrintArray(NewList(m, n));


// //---------------------------Методы -----------------------

// double[,]  NewList(int line, int vertical)      // Создает двумерный массив, заполненный вещественными числами, с указанным кол-вом строк и линий
// {   
//     double[,] list = new double[line, vertical];
//     for (int i = 0; i < line; i++)
//     {   
//         for(int j = 0; j < vertical; j ++)
//         {
//             list[i, j] = new Random().Next(-100,100) / 10;
//         }
//     }
//     return list;
// }

// void PrintArray(double[,] array)               // Выводит в консоль двумерный массив
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
int a = new Random().Next(1, 7);
int b = new Random().Next(1, 7);
int[,] list = NewList(a, b);
PrintArray(list);
SearchByIndex(list, a, b);


//---------------------------Методы -----------------------

int[,]  NewList(int line, int vertical)      // Создает двумерный массив, заполненный целыми числами, с указанным кол-вом строк и линий
{   
    int[,] list = new int[line, vertical];
    for (int i = 0; i < line; i++)
    {   
        for(int j = 0; j < vertical; j ++)
        {
            list[i, j] = new Random().Next(0,9);
        }
    }
    return list;
}


void PrintArray(int[,] array)               // Выводит в консоль  массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


void SearchByIndex(int[,] array, int line, int vertical)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        int counter = 0;
        for (int j = 0; j < array.GetLength(1); i++)
        {
            if(i == line && j == vertical)
            {
                Console.WriteLine(array[i, j]);
                break;
            }
        
        }
    }
    
}