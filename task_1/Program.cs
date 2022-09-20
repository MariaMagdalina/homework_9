﻿// данная программа упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
Random rand = new Random();

// функция заполнения двумерного массива случайными числами
void fill_array(int [,] arr)
{
   for(int i=0; i < arr.GetLength(0); i++)
   {
      for(int j=0; j < arr.GetLength(1); j++)
      {
         arr[i,j] = rand.Next(0,100);
      }
   }
}

// функция у, которая порядочит по убыванию элементы каждой строки двумерного массива
void sort_descend(int [,] arr)
{
   for(int i=0; i < arr.GetLength(0); i++)
   {
      for(int j=0; j < arr.GetLength(1); j++)
      {
         for(int k=0; k < arr.GetLength(1)-1; k++)
         {
            if(arr[i,k] < arr[i,k+1])
            {
               int a = arr[i,k+1];
               arr[i,k+1] = arr[i,k];
               arr[i,k] = a; 
            }
         }
      }
   }
}

// основная программа
int row = rand.Next(2,10);
int column = rand.Next(2,10);
int [,] array = new int [row,column];

fill_array(array); // заполняем массив элементами
Console.WriteLine("исходный массив: ");// выводим массив
 for(int i=0; i < array.GetLength(0); i++)
 { 
   for(int j=0; j < array.GetLength(1); j++)
   {
     Console.Write(array[i,j] + "  ");
   }
   Console.WriteLine();
 }
Console.WriteLine();

sort_descend(array); // сортируем массив
Console.WriteLine("отсортированный массив: "); // выводим отсортированный массив
 for(int i=0; i < array.GetLength(0); i++)
 { 
   for(int j=0; j < array.GetLength(1); j++)
   {
     Console.Write(array[i,j] + "  ");
   }
   Console.WriteLine();
 }

/*
bool Contains(int[,] arr, int value) 
{
    for(int i =0; i < arr.GetLength(0) ; i++)
      {
         for(int j=0; j < arr.GetLength(1) ; j++)
         {
            if(arr[i,j] == value)
            return true;
         }
      }
    return false;
}

// функция заполнения двумерного массива случайными числами
void fill_array(int [,] array)
{
   for(int i=0; i < array.GetLength(0); i++)
      {
         for(int j=0; j < array.GetLength(1); j++)
         {
            int value = rand.Next(10,100);
            while(Contains(array, value))
            {
               value = rand.Next(10,100);              
            }
             array[i,j] = value;
         }
      }
}  



// основная программа
int row = rand.Next(2,8); // задаем количество строк
int column = rand.Next(2,8); // задаем количество столбцов
int [,] array = new int [row,column]; // создаем двумерный массив 1
fill_array(array); // заполняем массив элементами
// выводим массив
 for(int i=0; i < array.GetLength(0); i++)
 { 
   for(int j=0; j < array.GetLength(1); j++)
   {
     Console.Write(array[i,j] + "  ");
   }
   Console.WriteLine();
 }

*/