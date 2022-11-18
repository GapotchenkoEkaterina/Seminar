// // Однострочный комментарий

// /* Многострочный
// ввп
// вапв
// вп
// */

// // напишите программу, которая на вход принимает число и выдает его квадрат

// // Вариант 1

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Введи число: ");
//         int number = int.Parse(Console.ReadLine()!);

// int sqr = number * number;

// Console.WriteLine($"Квадрат числа {number} = {sqr}");
/*
// Вариант 2

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} = {sqr1}");
*/

// Вариант 3

// Console.WriteLine("Введите числа ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите числа ");
// int B = int.Parse(Console.ReadLine()!);
// if (A==B/A)
// {
//     Console.Write("Да");
// }else{Console.Write("Нет");

// }

// Вариант 4 

// Console.WriteLine("Введите числа ");
// int P = int.Parse(Console.ReadLine()!);
// if (P==1) Console.WriteLine("Понедельник ");
// if (P==2) Console.WriteLine("Вторник ");
// if (P==3) Console.WriteLine("Среда ");
// if (P==4) Console.WriteLine("Четверг ");
// if (P==5) Console.WriteLine("Пятница ");
// if (P==6) Console.WriteLine("Суббота ");
// if (P==7) Console.WriteLine("Воскресенье ");

// Домашнее задание: Задача №2

// Console.WriteLine("Введите числа ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите числа ");
// int B = int.Parse(Console.ReadLine()!);
// if (A>B)
// { 
//     int max = A;
//     Console.WriteLine($"Максимальное значение = {A}");

// }else{ int max = B;
//     Console.WriteLine($"Максимальное значение = {B}");
// }

// Домашнее задание: Задача №4

// Console.WriteLine("Введите число А ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число В ");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число С ");
// int C = int.Parse(Console.ReadLine()!);
// int max = A;
// if (A>max) max=A;
// if (B>max) max=B;
// if (C>max) max=C;
// Console.WriteLine($"Максимальное значение = {max}");

//  Домашнее задание: Задача №6

// Console.WriteLine("Введите число А ");
// int A = int.Parse(Console.ReadLine()!);
// if (A % 2 == 0)
// {Console.WriteLine($"Число является четным = {A}");
// }
// else {Console.WriteLine($"Число является нечетным = {A}");
// }

//  Домашнее задание: Задача №8

// Console.WriteLine("Введите число N ");
// int N = int.Parse(Console.ReadLine()!);
// int N2 = 1;
// while (N2 <= N)
// { 
// if (N2 % 2 == 0)
// Console.WriteLine($"Число является четным = {N2}");
// N2++;
// }

// Второй семенар 

// задача: Напишите программу, которая вводит случайное трехзначное число и удаляет вторую цифру

// int number = new Random().Next(100, 1000);

// Первый метод
// Console.WriteLine(number);
// Console.WriteLine($"Число без второй цифры иммеет вид: {number/100}{number%10}");
// Console.WriteLine();
// int result = (number/100)*10 + number%10;
// Console.WriteLine(result);

// Второй метод (строковый)

// Console.WriteLine("Введите трехзначное число: ");
// string Numbers = Console.ReadLine()!;

// if(Numbers.Length !=3){
//     Console.WriteLine ("Введено неверное число");
// }
// else {
//     Console.WriteLine ($"Число без второй цифры иммеет вид: {Numbers[0]}{Numbers[2]}");
// }

// Первое задание

// int number = new Random().Next(10, 100);
// Console.WriteLine(number);

//  if (number/10 > number%10)
//  {Console.WriteLine (number/10);
//  }
//  else{
//     Console.WriteLine (number%10);
//  }

// Второе задание
//  Console.WriteLine("Введите число А ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число В ");
// int B = int.Parse(Console.ReadLine()!);

// if (A % B == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else{
//     Console.WriteLine($"Не кратно, остаток {A%B}");
// }

// Третье задание

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);

// if(num % 7 ==0 && num % 23 ==0 ) Console.WriteLine("Да");
// else Console.WriteLine("Нет");

// Четвертое задание
//  Console.WriteLine("Введите число А ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число В ");
// int B = int.Parse(Console.ReadLine()!);
// if (A * A == B || B * B == A) Console.WriteLine("Является");
// else Console.WriteLine("Не является");

// Домашнее задание: 
// Задача №10. Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков

// Console.WriteLine("Введите трехзначное число: ");
// string Numbers = Console.ReadLine()!;

// if(Numbers.Length !=3){
//     Console.WriteLine ("Введено неверное число");
// }
// else {
//     Console.WriteLine ($"Число без первой и третьей цифры иммеет вид: {Numbers[1]}");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Берем числа до 100000

// Console.WriteLine("Введите число: ");
// string Numbers = Console.ReadLine()!;
// if(Numbers.Length <3)  Console.WriteLine("Третье число отсутствует");
// else{
// Console.WriteLine($"Третья цифра иммеет вид: {Numbers[2]}");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7


// Console.WriteLine("Введите день недели: ");
// int num = int.Parse(Console.ReadLine()!);

// switch (num)
// {
//     case 1:{
//         Console.WriteLine("Это будний день");
//         break;
//     }
//         case 2:{
//         Console.WriteLine("Это будний день");
//         break;
//     }
//         case 3:{
//         Console.WriteLine("Это будний день");
//         break;
//     }
//         case 4:{
//         Console.WriteLine("Это будний день");
//         break;
//     }
//         case 5:{
//         Console.WriteLine("Это будний день");
//         break;
//     }
//         case 6:{
//         Console.WriteLine("Это выходной день");
//         break;
//     }
//         case 7:{
//         Console.WriteLine("Это выходной день");
//         break;
//     }
//     default:{
//         Console.WriteLine("Такого дня не существует");
//         break;
//     }
// }



// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);


// if (num > 0 && num < 8) 

//     if (num == 6 || num == 7)
//     {
//        Console.Write("Данный день является выходным");
//     }      
//     else
//     {
//     Console.Write("Данный день является будним");
//        }
// else 
//      Console.Write("Ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    
