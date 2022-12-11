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

// _________________________________________Домашнее задание к пятому Семинару___________________________________________________________


 
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
 
// [345, 897, 568, 234] -> 2
 
// int[] array = GetArray(5);
// Console.WriteLine($"[{String.Join(" ,", array)}]");
// Console.WriteLine($"В массиве количество четных чисел равняется {Count(array)}");
 
// int[] GetArray(int num){
//     int[]mas = new int[num];
//     for(int i = 0; i < mas.Length; i++){
//         mas[i] = new Random().Next(100,1000);
//     }
//     return mas;
// }
 
// int Count(int[] mas)
// {
//     int count = 0;
//     foreach(int el in mas){
//         if(el % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
 
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).
 
// [3, 7, 23, 12] -> 19
 
// [-4, -6, 89, 6] -> 0
 
// int[] array = GetArray(5);
// Console.WriteLine($"[{String.Join(" ,", array)}]");
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равняется {Count(array)}");
 
// int[] GetArray(int num){
//     int[]mas = new int[num];
//     for(int i = 0; i < mas.Length; i++){
//         mas[i] = new Random().Next(1000);
//     }
//     return mas;
// }
 
// int Count(int[] mas)
// {
//     int count = 0;
//     for(int i = 0; i < mas.Length; i+=1){
//         if(i%2!=0) 
//         count = count += mas[i];
        
//     }
//     return count;
// }
 
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
 
// [1 2 3 4 5] -> 5 8 3
 
// [6 7 3 6] -> 36 21
 
// Console.WriteLine("Введите размер массива: ");
 
// int num = int.Parse(Console.ReadLine()!);
 
// int [] array = new int [num];
// GetArray(array);
 
// PairArray(array);
 
// void GetArray(int[] array)
// {
//     for(int i=0; i<array.Length; i++){
//         array[i] = new Random().Next(-999,999);
//     }
//     Console.WriteLine($"Массив:  [{String.Join(" , ",array)}]");
// } 
 
//  void PairArray(int[] array)
//  {  
//     int[] mult = new int [(array.Length/2)+1];
//     int a = 0;
//     int i = 0;
//     int len = array.Length-1;
//     while(i < len)
//     {
//     mult[a] = array[i] * array[len];
//     a++;
//     i++;
//     len--; 
//    }
 
//    if (array.Length%2 > 0){
//     mult[a] = array[array.Length/2];
//    }
//    else{
//     mult[a] = 0;
//    }
//    Console.WriteLine($"Массив перемноженных элементов:  [{String.Join(" , ",mult)}]");
//    }



 
// Задача 38: Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.
 
// int[] array = GetArray(5);
// Console.WriteLine($"[{String.Join(" ,", array)}]");
// Console.WriteLine($"{maxValue(array)}, {minValue(array)}");
// Console.WriteLine($" Разницу между максимальным и минимальным элементов массива {maxValue(array)-minValue(array)}");
 
// int[] GetArray(int num){
//     int[]mas = new int[num];
//     for(int i = 0; i < mas.Length; i++){
//         mas[i] = new Random().Next(-10,11);
//     }
//     return mas;
// }
 
// int maxValue(int[] mas)
// {int max = 0;
    
//     for(int i = 0; i < mas.Length; i++){
        
//         if(mas[i] > max) 
//         max = mas[i];
        
//     }
//     return max;
// }
 
// int minValue(int[] mas)
// {int min = 0;
//     for(int i = 0; i < mas.Length; i++){
//         if(mas[i] < min) 
//         min = mas[i];
        
//     }
//     return min;
// }

// _________________________________________Шестой Семинар___________________________________________________________
 
// Задача 39: Напишите программу, которая перевернет одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
 
// int[] array = GetArray(10, 0, 10);
// Console.WriteLine($"[{String.Join(", ", array)}]");
 
// int[] result = ReverseArray2(array);
// Console.WriteLine($"[{String.Join(", ", result)}]");
 
// Reversearray1(array);
// Console.WriteLine($"[{String.Join(", ", result)}]");
 
// // - - - - - - - - - -- - - -- - -- -- -- - Методы - - - - - - - - - - - - - - - - - -- - - - - - - - - -- 
// int[] GetArray(int size, int minValue, int maxValue){
//     int[] result = new int [size];
//     for(int i = 0; i < size; i++){
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
 
// void Reversearray1 (int[] array){
//     for(int i = 0; i < array.Length / 2; i++){
//         int temp = array[i];
//         array[i] = array[array.Length - i -1];
//         array[array.Length - i - 1] = temp;
//     }
// }
 
// int[] ReverseArray2 (int[] array){
//     int[] result = new int[array.Length];
//     for(int i = 0; i < array.Length; i++){
//         result[i] = array[array.Length - i - 1];
//     }
//     return result;
// }
 
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
 
// int A,B,C;
// Console.WriteLine("Введите сторону А:");
// A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите сторону B:");
// B = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите сторону C:");
// C = int.Parse(Console.ReadLine()!);
// if(Treugol(A, B, C))
//     Console.WriteLine("Такой треугольник существует!");
// else
//     Console.WriteLine("Такой треугольник не существует!");


 
// Console.WriteLine($"{Treugol(A, B, C)}");
 
// bool Treugol(int A, int B, int C){
//     if((A + B) > C && (A + C) > B && (B + C) > A)
//        return true;
//     return false;
// }


 
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное
// Делится число на 2 и записываются его остатки с конца в начало
 
// Console.WriteLine("Введите десятичное число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine(RereNum(A));
 
// string RereNum(int num)
// {
//     string result ="";
//     while (num != 0)
//     {
//         int num1 = num % 2;
//         num = num / 2;
//         string num3 = Convert.ToString(num1);
//         result = result + num1;
//     }
//     return result;
// }
 
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 то 0 1 1 2 3 
// Если N = 3 то 0 1 1  
// Если N = 7 то 0 1 1 2 3 5 8
 
// int n = 20;
 
// int first = 0;
 
// int second = 1;
 
// Console.Write($"{first} {second}");


 
// for (int i = 3; i <= n; i++){
 
//     int num = 0;
 
//     num = first + second;
 
//     Console.Write($" {num}");
 
//     first = second;
 
//     second = num;
 
// }
 
// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
 
// int[] arr = GetArray(10);
// Console.WriteLine($"[{String.Join(", ",arr)}]");
// Console.WriteLine($"[{String.Join(", ",CopyArray(arr))}]");
 
// int[] CopyArray(int[] array){
//     int[] copyArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         copyArray[i] = array[i];
//     }
//     return copyArray;
// }
 
// int[] GetArray(int size, int minValue = 0, int maxValue = 10){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }
 
// _________________________________________Домашнее задание к Шестому Семинару___________________________________________________________
 
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
 
// Console.WriteLine("Введите числа: ");
// int[] Numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
// int count = 0;
// for(int i = 0; i < Numbers.Length; i++){
//     if(Numbers[i] > 0)
//     count++;
// }
// Console.WriteLine($"Положительных чисел: {count}");
 
// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
 
// Console.WriteLine("Введите размер массива: ");
 
// int num = int.Parse(Console.ReadLine()!);
 
// int [] array = new int [num];
// GetArray(array);
// Console.WriteLine($"Массив:  [{String.Join(" , ",SortArray(array))}]");  
 
// void GetArray(int[] array)
// {
//     for(int i=0; i<array.Length; i++){
//         array[i] = new Random().Next(0,101);
//     }
//     Console.WriteLine($"Массив:  [{String.Join(" , ",array)}]");
// } 
 
//  int[] SortArray(int[] array)
//  {
 
//      for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = 0; j < array.Length - 1; j++)
//         {
//             if (array[j] > array[j + 1])
//             {
//             int temporary = array[j];
//             array[j] = array[j + 1];
//             array[j + 1] = temporary;
//             }        
//         }
//     }
//     return array;
// }

// _________________________________________Седьмой Семинар___________________________________________________________
 
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
 
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
 
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
 
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
 
// // ------------------Методы-----------------------
 
// // Метод создания двумерного массива
 
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
 
// // Метод печати двумерного массива
 
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }


 
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
 
//  m = 3, n = 4.    
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
 
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
 
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
 
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
 
// // ------------------Методы-----------------------
 
// // Метод создания двумерного массива
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = i + j;
//         }
//     }
//     return result;
// }
 
// Метод печати двумерного массива
 
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
 
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
 
// Новый массив будет выглядеть вот так:
 
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
 
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
 
// Задача 51(1): Задать двумерный массив и сделать сортировку элементов по возрастанию в нечетных столбцах
//  Решение задач 49 и 51
 
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
 
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows,columns,0,10);
 
// PrintArray(array);
// GetArrayMethod(array);
// Console.WriteLine("====================");
// PrintArray(array);
// GetDiag(array);
// GetSortColumnNec(array);
 
// // ------------------Методы-----------------------
 
// // Метод создания двумерного массива
 
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
 
// // // Метод печати двумерного масссива
 
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
 
//  Метод замены  элементов на их квадраты.
 
// void GetArrayMethod(int[,] array){
//  for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i%2==0 && j%2==0) array[i,j]=(int)Math.Pow(array[i,j],2) ;
//         }
//     }
// }
 
//  Метод нахождения суммы элементов находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
 
// void GetDiag(int[,] array){
// int sum =0;
//  for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i==j){
//                 Console.Write($"{array[i,j]} + ");
//                 sum=sum+array[i,j];
//             }
//         }
//     }
//      Console.WriteLine($"Сумма = {sum}");
// }
 
// метод сортировки элементов по возрастанию в нечетных столбцах
 
// void GetSortColumnNec(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (j % 2 != 0)
//         {
//             bool flag = true;
//             while (flag)
//             {
//                 flag = false;
//                 for (int i = 0; i < array.GetLength(0) - 1; i++)
//                 {
//                     if (array[i, j] > array[i + 1, j])
//                     {
//                         int stakan = array[i, j];
//                         array[i, j] = array[i + 1, j];
//                         array[i + 1, j] = stakan;
//                         flag = true;
//                     }
//                 }
//             }
//         }
//     }
// }
 
// _________________________________________Домашнее задание к Седьмому Семинару___________________________________________________________
 
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
 
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows,columns,0,10);
 
// PrintArray(array);
// GetAvgColumn(array);
 
// ------------------Методы-----------------------
 
// Метод создания двумерного массива
 
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
 
// // Метод печати двумерного массива
 
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
 
// void GetAvgColumn(int[,] array)
// {
//     Console.Write("[");
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         {
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 sum = sum + array[i, j];
//             }
//             Console.Write($"  {(sum / array.GetLength(0)):f2}  ");
//         }
//     }
//     Console.WriteLine("]");
// }
 
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
 
// i = 5; j = 2 -> такого числа в массиве нет
// i = 1; j = 1 -> 9
 
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
 
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows,columns,0,10);
// PrintArray(array);
 
// Console.WriteLine("Введите номер строки массива: ");
// int srows = int.Parse(Console.ReadLine()!)-1;
 
// Console.WriteLine("Введите номер столбца массива: ");
// int scolumns = int.Parse(Console.ReadLine()!)-1;
 
// Searchnumbyloc(array, srows, scolumns);
 
// ------------------Методы-----------------------
 
// Метод создания двумерного массива
 
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
 
// // Метод печати двумерного массива
 
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
 
// Метод поиска элемента по позиции в двумерном массиве
 
// void Searchnumbyloc(int[,]array, int srows, int scolumns){    
//     int sernumber = 0;
//     for(int i = 0; i < array.GetLength(0); i++){        
//         for(int j = 0; j < array.GetLength(1); j++){
//             if(i == srows && j == scolumns){
//                 sernumber = array[i,j]; Console.WriteLine($"Найдено число {array[i,j]}");
//             }
//         }
//     }  
//         if(srows < 0 | srows > array.GetLength(0)-1 | scolumns <0 | scolumns > array.GetLength(0)-1){ 
//             Console.WriteLine("Данного числа нет в массиве");}                
// }       



 
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
 
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
 
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// double[,] array = GetArray(rows,columns);
 
// PrintArray(array);


 
// ------------------Методы-----------------------
 
// Метод создания двумерного массива
 
// double[,] GetArray(int m, int n){
//     double[,] result = new double[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().NextDouble();
//                                }
//     }
//     return result;
// }
 
// Метод печати двумерного массива
 
// void PrintArray(double[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]:f1} ");
//         }
//         Console.WriteLine();
//     }
// }

// _________________________________________Восьмой Семинар___________________________________________________________
//  Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
 
// Например, задан массив:
 
// 1 4 7 2
 
// 5 9 2 3
 
// 8 4 2 4
 
// В итоге получается вот такой массив:
 
// 8 4 2 4
 
// 5 9 2 3
 
// 1 4 7 2
 
// Console.Write("Введите кол-во строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите кол-во столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] arrayFirst = GetArray(rows, columns, 10, 99);
// PrintArray(arrayFirst);
// Console.WriteLine("=====================");
 
// SortArray(arrayFirst);
 
// PrintArray(arrayFirst);
 
// if (arrayFirst.GetLength(0) == arrayFirst.GetLength(1))
// {
//     int[,] arraySecond = RouteArray(arrayFirst);
//     PrintArray(arraySecond);
// }
// else Console.WriteLine("Матрица не квадратная i<>j");
 
// int[,] GetArray(int rows, int columns, int minValues, int maxValues)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < rows; j++)
//         {
//             array[i, j] = new Random().Next(minValues, maxValues + 1);
//         }
//     }
//     return array;
// }
 
// void SortArray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp = array[0, j];
//         array[0, j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = temp;
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}  ");
//         }
//         Console.WriteLine("]");
//     }
// }
 
// Метод разворота массива (строки меняются местами со столбцами)
 
// int[,] RouteArray(int[,] array)
// {
//     int[,] array2= new int[array.GetLength(0),array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array2[j, i]=array[i,j];
//         }
//     }
//  return array2;
// }
 
//Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент
 
// int[,] ArrayDell(int[,] array){
//     int numbeMin = array[0,0];
//     int num1=0 , num2 =0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (numbeMin>array[i,j])
//             { 
//                 numbeMin=array[i,j];
//                 num1=i ;
//                 num2 = j;
//             }
//         }
//     }
 
//     int [,] array2 = new int[array.GetLength(0)-1,array.GetLength(1)-1];
//     for (int i = 0 , x = 0 ; i < array.GetLength(0); x++, i++)
//     {
//         if ( i== num1) {
//             x--;
//             continue;
//         }
//         for (int j = 0 , y = 0; j < array.GetLength(1); y++, j++){
//             if ( j== num2) {
//             y--;
//             continue;
//             }
//             array2[x,y]=array[i,j];
//         }
//     }
//     return array2;
// }
 
// int[,] GetArrayMin(int[,] array)
// {
//     int iMin = 0, jMin = 0, min = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (min > array[i, j])
//             {
//                 min = array[i, j];
//                 iMin = i;
//                 jMin = j;
//             }
//         }
//     }
 
//     Console.WriteLine($"Минимум [{iMin}, {jMin}] = {min}");
//     int[,] arrayMin = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     for (int i = 0; i < arrayMin.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayMin.GetLength(1); j++)
//         {
//             arrayMin[i,j]=array[i+(i<iMin ? 0 : 1),j+(j<jMin ? 0 : 1)];
//         }
//     }
//     return arrayMin;
// }
 
// _________________________________________Домашнее задание к Восьмому Семинару___________________________________________________________
 
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
 
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
 
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows,columns,0,10);
 
// PrintArray(array);
// Console.WriteLine("====================");
// // GetSortColumn(array);
// // PrintArray(array);
// GetSumarows(array);
 
// ------------------Методы-----------------------
 
// Метод создания двумерного массива
 
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
 
// Метод печати двумерного масссива
 
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
 
// // метод сортировки элементов по убыванию элементов в строке
// void GetSortColumn(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temporary = array[i, k];
//                     array[i, k] = array[i, k + 1];
//                     array[i, k + 1] = temporary;
//                 }
//             }
//         }
//     }
// }
 
// метод нахождения суммы элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
 
// void GetSumarows(int[,] array){
//         int index = 0; 
//         int minsum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//         }
//         Console.WriteLine($"{sum}");
//         if (i == 0)
//         {
//             minsum = sum;
//         }
//         else if (sum < minsum)
//         {
//             minsum = sum;
//             index = i;
//         }
 
//     }
//     Console.WriteLine($"Строка с минимальной суммой элементов равна {index+1}. ");
// }
 
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
 
// Console.WriteLine("Введите количество строк 1-го массива: ");
// int rows = int.Parse(Console.ReadLine()!);
 
// Console.WriteLine("Введите количество столбцов 1-го массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows,columns,0,10);
 
// Console.WriteLine("Введите количество строк 2-го массива: ");
// int rows2 = int.Parse(Console.ReadLine()!);
 
// Console.WriteLine("Введите количество столбцов 2-го массива: ");
// int columns2 = int.Parse(Console.ReadLine()!);
// int[,] array2 = GetArray(rows,columns,0,10);
 
// PrintArray(array);
// Console.WriteLine("=====================");
// PrintArray(array2);
// Console.WriteLine("====================");
// PrintArray(arraymult(array,array2));
       
 
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
 
// Метод печати двумерного масссива
 
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
 
// метод умножения матриц
 
// int[,] arraymult(int[,] array, int[,] array2)
//         {
//             int[,] array3 = new int[array.GetLength(0), array2.GetLength(1)];           
//             if(array.GetLength(0) == array2.GetLength(1)){
//                 for (int i = 0; i < array.GetLength(0); ++i){
//                     for (int j = 0; j < array2.GetLength(0); ++j){
//                         for (int k = 0; k < array2.GetLength(1); ++k){
//                            array3[i, k] += array[i, j] * array2[j, k];}          
//                     }
//                 }
//             } return array3;
//         }



 
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
 
// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
 
// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows,columns);
// PrintArray(array);
 
// int[,] GetArray(int m, int n){
//     int[,] result = new int[m,n];
//     int number = 1;
//         for(int i = 0; i < m; i++)
//             for(int j = 0; j < n; j++)
//                 while(number <= n * m){
//                 result[i, j] = number;
//                 if (i <= j + 1 && i + j < n -1)
//                 ++j;
//                 else if (i < j && i + j >= n - 1)
//                 ++i;
//                 else if (i >= j && i + j > n - 1)
//                 --j;
//                 else
//                 --i;
//                 ++number;}
            
//     return result;
// }
 
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
