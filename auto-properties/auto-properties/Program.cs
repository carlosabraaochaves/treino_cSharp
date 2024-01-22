using System;
using auto_properties;

namespace autoProperties
{



    class Program
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos("Geladeira");
            // Alterando nome e preço pelo AUTO PROPERTIES  e PROPERTIES

            p.SetNome("Computador");
            
            
            Console.WriteLine(p.Preco);
        }
    }
}