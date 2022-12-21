/*Задача 64. Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */

int GetNumber(string text) 
{     
    int result = 0;       
    while(true)     
    {        
        Console.WriteLine(text); 
        if (int.TryParse(Console.ReadLine(), out result) && result > 1)         
        {             
            break;         
        }         
        else         
        {             
            Console.WriteLine("Некорректно ввели число");         
        }     
    }     
    return result; 
}

void Value(int N) 
{   
    Console.Write($"{N}, "); 
    if (N > 1)     
    {         
      Value(N-1);  
    }     
} 

int N = GetNumber("Введите число N: ");
Value(N);
