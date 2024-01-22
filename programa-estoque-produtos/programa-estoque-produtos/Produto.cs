

namespace programa_estoque_produtos
{
    internal class Produto
    {
       public  string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {           
            
            return Preco * Quantidade;
        }


        public void AdicionarProdutos(int quantidade)
        {

        }


        public void RemoverProdutos(int quantidade)
        {

        }

        public override string ToString()
        {
            return Nome + " , $ " + Preco;
        }
    }
}
