using DotNetBasics.Aula10.Model;
using DotNetBasics.Aula10.Service;

namespace DotNetBasics.Aula10.Tests.Service;
public class ProdutoService_ObterProdutoPorId
{
    private readonly ProdutoService _produtoService;

    public ProdutoService_ObterProdutoPorId()
    {
        _produtoService = new ProdutoService();
    }

    [Fact]
    public void ObterProdutoPorId_ValidId_ReturnsProduto()
    {
        // Arrange
        var testProdutos = new List<Produto>
        {
            new Produto { Id = "1", Preco = 10 },
            new Produto { Id = "2", Preco = 20 },
        };
        typeof(ProdutoService)
            .GetField("produtos", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
            ?.SetValue(null, testProdutos);

        // Act
        var result = _produtoService.ObterProdutoPorId("1");

        // Assert
        Assert.NotNull(result);
        Assert.Equal("1", result.Id);
        Assert.Equal(10, result.Preco);
    }

    [Fact]
    public void ObterProdutoPorId_InvalidId_ReturnsNull()
    {
        // Arrange
        var testProdutos = new List<Produto>
        {
            new Produto { Id = "1", Preco = 10 },
            new Produto { Id = "2", Preco = 20 },
        };
        typeof(ProdutoService)
            .GetField("produtos", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
            ?.SetValue(null, testProdutos);

        // Act
        var result = _produtoService.ObterProdutoPorId("3");

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void ObterProdutoPorId_EmptyProductList_ReturnsNull()
    {
        // Arrange
        typeof(ProdutoService)
            .GetField("produtos", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
            ?.SetValue(null, new List<Produto>());

        // Act
        var result = _produtoService.ObterProdutoPorId("1");

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void ObterProdutoPorId_NullId_ReturnsNull()
    {
        // Arrange
        var testProdutos = new List<Produto>
        {
            new Produto { Id = "1", Preco = 10 },
            new Produto { Id = "2", Preco = 20 },
        };
        typeof(ProdutoService)
            .GetField("produtos", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
            ?.SetValue(null, testProdutos);

        // Act
        var result = _produtoService.ObterProdutoPorId(null);

        // Assert
        Assert.Null(result);
    }
}
