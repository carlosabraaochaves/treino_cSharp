using System;
using System.Numerics;
using System.Runtime.Serialization;


namespace For
{


    class Program
    {




        static void Main(string[] args)
        {
            // Exercício prático de loop FOR

               
                Console.Write("Quantos números inteiros você vai digitar: ");
                int qtdNumeros = int.Parse(Console.ReadLine());
            int numero = 0;
            int total = 0;
            

            for (int i = 1; i <= qtdNumeros; i++)
            {
                Console.WriteLine("Digite um número: ");
                 numero = int.Parse(Console.ReadLine());

                total += numero;

               

                

            }
            Console.WriteLine("O resultado é " + total);

        }
    }




}
