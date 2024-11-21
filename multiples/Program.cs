/*
 Дано N (10 ≤ N ≤ 25). 
Найти количество чисел от 50 до 150 (включая эти числа), которые кратны N. 
Операции деления (/, %) не использовать. А умножение не требуется. Посмотрите на задачу “Последовательность”
Число N всего одно, его надо получить в нужном диапазоне. Хоть с помощью Random, хоть ввод пользователя.
 */
using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {            
            int numberFirst = 10;
            int numberLast = 25;    
            Random random = new Random();
            int randomNumber = random.Next(numberFirst, numberLast);
            int firstNumber = 50;
            int lastNumber = 150; 
            int numberOfMultiples = 0;

            for (int i = 0; i <= lastNumber; i += randomNumber)
            {
                if (i >= firstNumber)
                {
                numberOfMultiples++;
                }
            }           

            Console.WriteLine($"Количество чисел от 50 до 150, кратных {randomNumber}: {numberOfMultiples}");
        }        
    }
}
