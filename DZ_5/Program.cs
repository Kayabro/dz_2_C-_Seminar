// // Задача 34

// int[]  array = GetArray(4, 100, 999);
// Console.WriteLine($"[{String.Join(",", array)}]");
// int counter = 0;

// foreach(int el in array)
// {
//     if(el % 2 ==0)
//     {
//         counter += 1;
//     }
// }
// Console.WriteLine($"Колличество четных элементов массива равно {counter}");

// // --------------------Методы-------------------------

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }



// // Задача 36
// int[] mass = NewList();
// Console.WriteLine($"Сумма Элементов с нечетным индексом, массива [{String.Join(" , ",mass)}], равна {GetSum(mass)}");

// int GetSum(int[] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 != 0)
//         {
//             summ += array[i];
//         }
//     }
//     return summ;   
// }


// int[]  NewList()
// {
//     int[] list = new int[4];
//     for (int i = 0; i < list.Length; i ++)
//     {
//         list[i] = new Random().Next(1,999);

//     }
//     return list;
// }




// Задача 37
int[] array = NewList();

Console.WriteLine($" произведение пар чисел в одномерном массиве [{String.Join(" , ", array)}], будет  [{String.Join(" , ", PairedNumbers(array))}]");

// ----------------------------------Методы-------------

int[]  NewList()
{   
    int LenList = new Random().Next(3,9);
    int[] list = new int[LenList];
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = new Random().Next(1,9);

    }
    return list;
}

int[] PairedNumbers(int[] mass)
{   
    int len = 0;
    if(mass.Length % 2 == 0)
    {
        len = mass.Length / 2;
    }
    else
    {
        len = mass.Length / 2 + 1;
    }
    int[] newMass = new int[len];
    int indexA = 0;
    int indexB = mass.Length - 1; 
    for (int i = 0; i < len; i++)
    {
        newMass[i] = mass[indexA] * mass[indexB];
        indexA += 1;
        indexB -= 1;
    }
    if(mass.Length % 2 != 0)
    {
        newMass[newMass.Length / 2 + 1] = Convert.ToInt32(Math.Sqrt(newMass[newMass.Length / 2 + 1]));
    }

    return newMass;
}

