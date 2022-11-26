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


// Второй вариант решения

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
    

// Задача №17: Определить, является ли заданное шестизначное число счастливым.
// (Счастливым называется такое число, что сумма его первых трех цифр равно сумме его последних трех цифр.)

// Console.WriteLine("Введите шестизначное число");
// string number = Console.ReadLine()!;
// if (number.Length == 6)
//    if (number[0]+number[1]+number[2]==number[3]+number[4]+number[5]) Console.WriteLine("Число является счастливым");
//    else {Console.WriteLine("Число не является счастливым");}
// else  Console.WriteLine("Введенное число не является шестизначным");


//  Напишите программу, которая принимает на ввод координаты двух точек и находит расстояние между ними в 2D пространстве
// A (3,6); B (2,1) - 5,09

// A (7,-5); B (1,-1) - 7,21

// int[] mas = {3,6,2,1};
// int[] mas = {7,-5,1,-1};

// double masR = Math.Sqrt(Math.Pow(mas[0]-mas[2],2) + Math.Pow(mas[1]-mas[3],2));
// Console.WriteLine($"{masR:f2}");


//  Напишите программу, которая принимает на ввод число "N" и выдает таблицу квадратов чисел от 1 до N
// 5 - 1,4,9,16,25.
// 2- 1,4.

// Console.WriteLine("Введите число N");
// int N = int.Parse(Console.ReadLine()!);

// for(int i =1; i<=N; i++)
// {
//     Console.WriteLine($"{Math.Pow(i,2)} ");
// }


// Домашнее задание к третьему семинару
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// string number = Console.ReadLine()!;
// if(number.Length == 5){
//     if(number[0]==number[4] && number[1]==number[3]) Console.WriteLine("Число является полиндромом");
//     else {Console.WriteLine("Число не является полиндромом");}
// }
// else Console.WriteLine("Введено не пятизначное число");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int [] mas = {3,6,8,2,1,-7};
// int [] mas = {7,-5,0,1,-1,9};
// double masR = Math.Sqrt(Math.Pow(mas[0]-mas[3],2) + Math.Pow(mas[1]-mas[4],2) + Math.Pow(mas[2]-mas[5],2));
// Console.WriteLine($"{masR:f2}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число N");
// int N = int.Parse(Console.ReadLine()!);
// for(int i=1; i <= N; i++)
// Console.WriteLine($"{Math.Pow(i,3)}");

// _________________________________________Домашнее задание к четвертому Семинару___________________________________________________________
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
 
// 3, 5 -> 243 (3⁵)
 
// 2, 4 -> 16
 
// Console.WriteLine("Введите Число А: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите Число B: ");
// int B = int.Parse(Console.ReadLine()!);
// if(B < 0) {B = B * -1;};
// Console.WriteLine($"Возведение числа {A} в степень числа {B} следующее {GetdegreeA(A)}");
// int GetdegreeA(int degree){
// int degreeA = 1;
//     for(int i = 1; i <= B ; i++){
//          degreeA = degreeA * A;
//          }  
//     return degreeA;
//     }
 
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 
// 452 -> 11
 
// 82 -> 10
 
// 9012 -> 12
 
// Console.WriteLine("Введите число n: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма чисел состовляющих число {n} будет равна {GetSum(n)}");
// int GetSum(int limit){
// int sum = 0; 
// while(n > 0){
//     int dig = n % 10;  
//     sum = sum + dig;   
//     n = n / 10;         
// }
// return sum;
// }


 
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
 
// int[] arr = array(8);
// Console.WriteLine($"Массив [{String.Join(", ",arr)}]");
// int[] array(int number){
//   int[] array1 = new int[number];{ 
//    for(int i=0; i < array1.Length; i++){
//     array1[i] = new Random().Next(0,650);
// }  
// return array1;
// }
// }

