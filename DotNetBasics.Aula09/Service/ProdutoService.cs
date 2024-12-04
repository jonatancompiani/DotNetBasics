using DotNetBasics.Aula09.Model;

namespace DotNetBasics.Aula09.Service;

public class ProdutoService : IProdutoService
{
    private static readonly List<Produto> produtos = [];

    public IEnumerable<Produto> ListarProdutos(decimal precoMin, decimal precoMax)
    {
        IEnumerable<Produto> filtered = produtos.Where(prod => prod.Preco >= precoMin && prod.Preco <= precoMax);

        return filtered;
    }

    public Produto? ObterProdutoPorId(string id)
    {
        return produtos.Find(p => p.Id == id);
    }

    public void CriarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public bool AtualizarProduto(Produto produto)
    {
        int index = produtos.FindIndex(p => p.Id == produto.Id);
        if (index == -1)
            return false;

        produtos[index] = produto;
        return true;
    }

    public bool RemoverProduto(string id)
    {
        var produto = produtos.Find(p => p.Id == id);
        if (produto == null)
            return false;

        produtos.Remove(produto);
        return true;
    }
}