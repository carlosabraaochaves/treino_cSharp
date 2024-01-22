using System;


namespace Construtores
{

    class program
    {
        static void Main(string[] args)
        {

            
            //  USANDO PROPETIES PARA ACESSA METODOS PRIVADOS

            Produto p = new Produto("Tv", 500, 10);

            p.Nome = "Geladeira";

            Console.WriteLine(p.Nome);





        }
    }

}