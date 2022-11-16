// // Задача № 10.  

// while(true)
// {   
//     Console.WriteLine("Введите число состоящее из 3 знаков");
//     string a = Console.ReadLine();
//     if(a.Length == 3)
// {      Console.WriteLine($"Второй символ - это {a[1]}");
//         break;
// }
//     else
// {
//     Console.WriteLine("Число должно содержать 3 знака!");
// }
// }


// // Задача № 13

// Console.WriteLine("Введите число до 100000");
// int number = int.Parse(Console.ReadLine()!);
// if (number > 99)
// {
//     while(number > 999)
// {
//         number = number / 10;
// }
// Console.WriteLine(number % 10);
// }
// else
// {
//     Console.WriteLine("Нет третьей цифры");
// }


// // Задача №15

// Console.WriteLine("Укажи день, проверим, выходной день или нет");
// int NumberDay = int.Parse(Console.ReadLine()!);
// if (NumberDay < 8 && NumberDay > 1)
// {
//     if( NumberDay == 6 || NumberDay == 7)
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
//     Console.WriteLine("Не бывает такого дня недели");
// }