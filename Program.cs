using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversãoTempFpC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercicio Senai 3
              Efetue a leitura de uma temperatura medida em graus Fahrenheit
              e apresente em Celsius.*/
            int temp_F,temp_C;
            Console.Write("Temperatura em Fº(fahrenheit): ");
            temp_F = int.Parse(Console.ReadLine());
            temp_C = ((temp_F - 32) * 5) / 9;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Temperatura em Celsius: " + temp_C + "C°");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();
            Console.Write("Tecle <enter> para sair");
            Console.ReadLine();
        }   
    }
}
