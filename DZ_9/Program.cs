// // Задача 64:

// Console.WriteLine("Введите натуральное число больше 1:");
// int number = int.Parse(Console.ReadLine()!);

// void NumberCounter (int number)
// {
//     if (number < 0) Console.Write($"{number} не натуральное число");
//     if (number == 0) return;
//     Console.Write($"{number},");
//     NumberCounter (number - 1);
// }

// NumberCounter(number);


// Задача 66:

// Console.WriteLine("Введите начальное число M:");
// int numberM = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите начальное число M:");
// int numberN = int.Parse(Console.ReadLine()!);

// void GapNumberSum (int numberM, int numberN, int sum)           //Метод нахождения суммы натуральных элементов в промежутке от M до N
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     GapNumberSum(numberM, numberN, sum);
// }
// GapNumberSum(numberM, numberN, 0);


////Задача 68:

// Console.WriteLine("Введите начальное число M:");
// int numberM = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите начальное число N:");
// int numberN = int.Parse(Console.ReadLine());

// ///Метод вычисления функции Аккермана:
// int AckermannFunction (int numberM, int numberN)
// {
//     if (numberM == 0) return numberN + 1;
//     if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
//     if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
// return AckermannFunction(numberM, numberN);
// }

// Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");