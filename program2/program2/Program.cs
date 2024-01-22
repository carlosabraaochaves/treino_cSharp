using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entradas no terminal
            Console.Write("Digite a frase: ");

            String frase = Console.ReadLine(); //entrada
            Console.WriteLine("Mostrando frase digitada: " + frase);// imprimindo entrada de dados

            //digitar três nomes na mesma linha e fazer com que ele sejam fatiados e colocador em variaveis diferentes

            Console.Write("digite 3 nomes separados por espaço: ");
            String nomes = Console.ReadLine();

            String[] vNomes = nomes.Split(' ');

            String nome1 = vNomes[0];
            String nome2 = vNomes[1];
            String nome3 = vNomes[2];

            Console.WriteLine("Mostrando nome recortados: ");

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);

           




        }
    }
}