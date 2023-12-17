using System.Globalization;
using Introducao_POO_Controle_Estoque;

Console.WriteLine("Entre com os dados do produto:");

Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine());

Produto p = new Produto()
{
    Nome = nome,
    Preco = preco,
    Quantidade = quantidade
};

p.MostrarDados();

Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
p.AdicionarProdutos(int.Parse(Console.ReadLine()));
p.MostrarDados();

Console.Write("Digite o número de produtos a ser removido ao estoque: ");
p.RemoverProdutos(int.Parse(Console.ReadLine()));
p.MostrarDados();
