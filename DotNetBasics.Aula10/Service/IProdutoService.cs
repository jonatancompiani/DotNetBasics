using DotNetBasics.Aula10.Model;

namespace DotNetBasics.Aula10.Service;

public interface IProdutoService
{
    IEnumerable<Produto> ListarProdutos(decimal precoMin, decimal precoMax);
    Produto? ObterProdutoPorId(string id);
    void CriarProduto(Produto produto);
    bool AtualizarProduto(Produto produto);
    bool RemoverProduto(string id);
}