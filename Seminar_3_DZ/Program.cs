// Задача №19.
// Вариант 1

// Console.WriteLine("Введите 5-ти значное число: ");
// string numbers = Console.ReadLine()!;
// if(numbers.Length == 5)
// {
//     if(numbers[0] == numbers[4] && numbers[1] == numbers[3])
//     {
//         Console.WriteLine("Да");
//     }
    
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }
// else
// {
//     Console.WriteLine("Число не 5-ти значное!");
// }

// Вариант 2   
// Console.WriteLine("Введите 5-ти значное число: ");
// int numbers = int.Parse(Console.ReadLine()!);
// if (numbers <= 99999 || numbers > 10000)
// {
//     if(numbers / 10000 == numbers % 10 && numbers / 1000 % 10 ==  numbers / 10 % 10 )
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }
// else
// {
//     Console.WriteLine("Число не 5-ти значное!");
// }

// Задача № 21
// int[] mass = {7, -5, 0, 1, -1, 9};

// double result = Math.Sqrt(Math.Pow(mass[3]- mass[0], 2) + Math.Pow(mass[4] - mass[1],  2) + Math.Pow(mass[5] - mass[2], 2));

// Console.WriteLine(result);


// Задача №23
// Console.WriteLine("Введите число : ");

// int n = Math.Abs((int.Parse(Console.ReadLine()!)));
// Console.WriteLine();

// for(int i = 1; i <= n; i += 1)
// {
//     Console.Write($"{Math.Pow(i, 3)},  ");
// }


