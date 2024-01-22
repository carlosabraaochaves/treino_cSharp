using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variavel do tipo sbyte -128 to 127
            sbyte x = 100;
            Console.WriteLine(x);

            // variavel do tipo char com caractere unicode

            char letra = '\u0041';
            Console.WriteLine(letra);

            // como saber o menor valor ou maior valor de cada tipo?
            //vamos ao exemplo:
            // menor valor inteiro

            int valor = int.MinValue;

            Console.WriteLine(valor);

            // maior valor inteiro

            int valorM = int.MaxValue;
            Console.WriteLine(valorM);


            // controlando formataçãod e casas decimais

            double saldo = 35.65789;

            Console.WriteLine(saldo.ToString("F3"));

            // fazer com que o programa execute o "."
            // ao invés da ","

            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));


            // usando placehouders "{}"

            String nome = "Maria";
            int idade = 21;
            double saldo1 = 100.00;

            Console.WriteLine("{0} tem {1} anos e um saldo de {2:F2} R$.", nome,idade,saldo1);
            // obs no valor "saldo" foi formatado para ter 2 casas

            // a seguir vou usar uma técnica de interpolação
            Console.WriteLine($"{nome} tem {idade} anos e um saldo de {saldo1:F2} R$.");

            // a seguir vou usar uma concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e um saldo de " + saldo1.ToString("F2") +  " R$.");

            
        }
    }
}