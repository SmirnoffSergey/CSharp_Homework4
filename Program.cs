// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите два числа");
// Console.Write("A = ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("B = ");
// int B = Convert.ToInt32(Console.ReadLine());

// void N1DegreeN2(int n1, int n2)
// {
//     int result = 1;
//     for (int i = 1; i <= n2; i++)
//     {
//         result = result * n1;
//     }
//     Console.WriteLine($"{n1} ^ {n2} = {result}");
// }
// N1DegreeN2(A, B);





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void SumNum(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         int n = number % 10;
//         sum = sum + n;
//         number = number / 10;
//     }
//     Console.WriteLine($"Сумма цифр этого числа равна {sum}");
// }
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// SumNum(N);





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// string PrintArray (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
    
//     string result = "[";  
//     for (int i = 0; i < arr.Length -1; i++)
//     {
//         result = result + $"{Convert.ToString(arr[i])}" + ", ";
//     }
//     result = result + $"{Convert.ToString(arr[arr.Length - 1])}" + "]";
//     return result;
// }
// int[] newarray = new int[8];
// Console.WriteLine("Введите поочередно 8 элементов"); 
// string str_array = PrintArray(newarray);
// Console.WriteLine(str_array);