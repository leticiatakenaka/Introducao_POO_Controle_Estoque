namespace Introducao_POO_Controle_Estoque
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public void MostrarDados()
        {
            Console.WriteLine(
                $"Dados do produto: {Nome}, R$ {Preco}, {Quantidade} unidades, Total: R$ {ValorTotalEmEstoque()}");
        }
    }
}