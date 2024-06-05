// Задача 3: Задайте произвольный массив. Выведете его 
// элементы, начиная с конца. Использовать рекурсию, не 
// использовать циклы.


void PrintArrayReverse(int[] array, int i)
{
   if (i <= 0) return;
   Console.Write(array[i]);
    PrintArrayReverse( array , i - 1);
}


int[] arr = {3, 5, 1, 8, 0, 7};
PrintArrayReverse(arr, arr.Length - 1);