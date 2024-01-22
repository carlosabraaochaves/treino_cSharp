

using System;


    namespace program3 {

    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler 3 valores, sendo: inteiro , char, double, logo em seguida ler( Maria F 23 1.68) e imprimir na tela. 
            Console.WriteLine("Digite os valor na sequência: \n Inteiro, Char e Double: ");
            int valor1 = int.Parse(Console.ReadLine());
            char valor2 = char.Parse(Console.ReadLine());
            double valor3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite um nome, um sexo, uma idade e um peso");

            String[] sValues = Console.ReadLine().Split(' ');

            Console.WriteLine("Mostrando valores conforme digitado: ");

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);


            String nome = sValues[0];
            char sexo = char.Parse(sValues[1]);
            int idade = int.Parse(sValues[2]);
            double peso = double.Parse(sValues[3]);


            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(peso);

        }
            }
        }
