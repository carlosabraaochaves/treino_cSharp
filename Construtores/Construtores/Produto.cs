using System;


namespace Construtores
{
    internal class Produto
    {

        private string _nome;
        private double _valor;
        private int _quantidade;

       

        public Produto(string nome, double valor, int quantidade)
        {
            _nome = nome;
            _valor = valor;
            _quantidade = quantidade;
        }

        //PROPERTIES 

        public string Nome
        {

            get { return  _nome; }
            set { _nome = value; }
        }

        // METODOS GET

        //public string GetNome()
        //{
        //    return _nome;
        //}


        //public void SetNome(string nome)
        //{
        //    _nome = nome;
        //}




        // TO STRING
        public override string ToString()
        {
            return _nome + " , $ " + _valor;
        }

    }
}
