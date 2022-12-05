// // Задача 41:

// Console.WriteLine("Укажите, из скольки чисел  будет список :");
// int n = int.Parse(Console.ReadLine()!);
// int[] list = new int [n];
// int counter = 0;
// for(int i = 0; i < n; i ++)
// {
//     Console.WriteLine("ведите число :");
//     list[i] = int.Parse(Console.ReadLine()!);
//     if(list[i]>0)
//     {
//         counter += 1;
//     }
// }
// Console.WriteLine($"Количество положительных чисел, больше ноля  в списке :[{String.Join(" , ", list)}], будет равно {counter}!");




// Задача 43:

int[] mass = NewList();
Console.WriteLine($"Изначальный список:[{String.Join(" , ", mass) }], отсортированный список:[{String.Join(" ," , SortList(mass))}]");
// int[] sort = SortList(mass);
// Console.WriteLine($"Отсортированный список:[{String.Join(" ," , sort)}]");

// ////-----------------------------Методы-------------------------
int[]  NewList()
{   
    int LenList = new Random().Next(6,11);
    int[] list = new int[LenList];
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = new Random().Next(0,100);
    }
    return list;
}
 
int[] SortList(int []list)
{
    for (int i = 0; i < list.Length; i++)
    {
            for (int j = 0; j < list.Length - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                int curr = list[j];
                list[j] = list[j + 1];
                list[j + 1] = curr;
                }
            }
    }
    return list;
}