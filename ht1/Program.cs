// // Задача 1: Задайте значения M и N. Напишите программу,
// //  которая выведет все натуральные числа в промежутке 
// //  от M до N. Использовать рекурсию, не использовать
// //   циклы.


void PrintNaturalNumbers(int firstNum, int secondNum)
{
    if(firstNum > secondNum ) return;
    
    Console.WriteLine($"{firstNum} ");
    
    PrintNaturalNumbers(firstNum + 1, secondNum);

}

Console.WriteLine("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());



PrintNaturalNumbers(m, n);

