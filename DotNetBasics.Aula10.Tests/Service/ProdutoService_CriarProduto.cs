using DotNetBasics.Aula10.Model;
using DotNetBasics.Aula10.Service;

namespace DotNetBasics.Aula10.Tests.Service;
public class ProdutoService_CriarProduto
{
    private readonly ProdutoService _produtoService;

    public ProdutoService_CriarProduto()
    {
        _produtoService = new ProdutoService();
    }

    [Fact]
    public void CriarProduto_ValidProduto_AddsProdutoToList()
    {
        // Arrange
        var testProduto = new Produto { Id = "1", Preco = 10 };
        typeof(ProdutoService)
            .GetField("produtos", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
            ?.SetValue(null, new List<Produto>());

        // Act
        _produtoService.CriarProduto(testProduto);

        // Assert
        var produtos = _produtoService.ListarProdutos(0,100);
        Assert.Contains(produtos, p => p.Id == "1" && p.Preco == 10);
    }

    [Fact]
    public void CriarProduto_NullProduto_ThrowsException()
    {
        // Arrange
        Produto testProduto = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => _produtoService.CriarProduto(testProduto));
    }

    [Fact]
    public void CriarProduto_DuplicateProduto_AddsToList()
    {
        // Arrange
        var testProduto = new Produto { Id = "1", Preco = 10 };
        typeof(ProdutoService)
            .GetField("produtos", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
            ?.SetValue(null, new List<Produto> { testProduto });

        // Act
        _produtoService.CriarProduto(testProduto);

        // Assert
        var produtos = _produtoService.ListarProdutos(0, 100);
        Assert.Equal(2, produtos.Count(p => p.Id == "1"));
    }
}
