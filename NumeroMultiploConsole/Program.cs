using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMultiploConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;int soma = 0;
            bool NumberIsValid = true;
            while (NumberIsValid == true)
            {
                Console.WriteLine("Console Calculadora de Numeros Multiplos em C#\r");
                Console.WriteLine("------------------------\n");
                try
                {
                    Console.WriteLine("Digite um numero natural para saber a soma dos numeros multiplo de 3 e 5: \r");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 < 0)
                        throw new System.FormatException();
                    NumberIsValid = false;
                    for (int i = 0; i <= num1; i++)
                    {
                        if (i % 3 == 0 || i % 5 == 0)
                        {
                            soma += i;
                        }
                    }
                    Console.WriteLine("\n O resultado da soma  dos numeros multiplos de 3 e 5 é: " + soma);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Digite um numero valido \r");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }
            }

        }
    }
}
