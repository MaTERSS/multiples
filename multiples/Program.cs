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
            int firstNumberForTheNumberN = 10;
            int lastNumberForTheNumberN = 25;    
            Random random = new Random();
            int randomNumber = random.Next(firstNumberForTheNumberN, lastNumberForTheNumberN + 1);
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

            Console.WriteLine($"Количество чисел от {firstNumber} до {lastNumber}, кратных {randomNumber}: {numberOfMultiples}");
        }        
    }
}
