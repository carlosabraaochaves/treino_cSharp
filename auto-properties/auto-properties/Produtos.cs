using System;


namespace auto_properties
{
    internal class Produtos
    {

        private string _nome;

        // posso pegar o valor do preço mais não posso edita-lo
        public double Preco {  get; private set; }

        // Construtor com argumentos
        // estou fixando um valor no preço
        public Produtos(string nome)
        {
            this._nome = nome;
            this.Preco = 580;
        }

        // Construtor sem argumentos

        public Produtos()
        {

        }

        // Propeties
        public string Nome { 
        
           get { return _nome; }       
           set { _nome = value; }
        }

        // Get 

        //public String GetNome(String nome)
        //{
        //    return _nome;
        //}


        //// Set 
        public void SetNome(String nome)
        {
            _nome = nome;
        }

        public override string ToString()
        {
            return ("Nome:  " + _nome + "Preço: " + Preco);
        }
        

        
    }
}
