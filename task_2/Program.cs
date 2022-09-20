// данная программа спирально заполняет числами от 1 до n двумерный массив n на n.

int n = 4; // размер матрицы
int [,] array = new int [n,n];
int row = 0; // подсчет пройденных строк
int number = 1; // элементы массива от 1 до n

while(number <= n*n)
{
   int i = row/2; // начальный ориентир для строк/столбцов
   int j = n-1-i; // конечный ориентир для строк/столбцов
   
   // заполняем строку слева-направо
   for(int k=i; k < n-i; k++)
   {
      array[i,k] = number;
      number++;
   }
   row++;
   
   // заполняем столбец сверху-вниз
   for(int k = row-i; k < n-i ; k++)
   {
      array[k,j] = number;
      number++;
   }
   
   // заполняем строку справа-налево
   for(int k = j-1; k >= i ; k--)
   {
      array[j,k] = number;
      number++;
   }
   row++;

   // заполняем столбец снизу-вверх
   for(int k = j-1; k > i ; k--)
   {
      array[k,i] = number;
      number++;
   }
} 

// выводим полученный массив
for(int i=0; i < n ; i++)
{
   for(int j=0; j < n ; j++)
   {
      Console.Write("  " + array[i,j]);
   }
   Console.WriteLine();
}

