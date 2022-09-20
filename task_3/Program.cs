// данная программа вычисляет функцию Аккермана с помощью рекурсии. 

// функция Аккермана
uint Akkerman_func(uint m, uint n)
{
   if(m == 0)
   {
      return (n+1);
   }    
   else
      if(m > 0 && n == 0)
      {
       return Akkerman_func(m-1, 1);
      }
      else
       return Akkerman_func(m-1, Akkerman_func(m, n-1));
}  

// основная программа
uint m = 3; 
uint n = 8;
uint a = Akkerman_func(m, n); // записываем в переменную а результат вычисления функции 
Console.WriteLine("Для чисел " + m + " и " + n + " результат: " + a);



