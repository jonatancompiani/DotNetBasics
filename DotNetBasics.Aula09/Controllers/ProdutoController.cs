using Microsoft.AspNetCore.Mvc;
using DotNetBasics.Aula09.Model;
using DotNetBasics.Aula09.Service;

namespace DotNetBasics.Aula09.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController(IProdutoService produtoService) : ControllerBase
{
    private readonly IProdutoService _produtoService = produtoService;

    [HttpGet("LerProduto/{Id}")]
    [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Get(string Id)
    {
       return base.Ok(_produtoService.ObterProdutoPorId(Id));
    }

    [HttpGet("ListarProduto")]
    [ProducesResponseType(typeof(IEnumerable<Produto>), StatusCodes.Status200OK)]
    public IActionResult Get(decimal? precoMin, decimal? precoMax)
    {
        try
        {
            precoMin ??= decimal.MinValue;
            precoMax ??= decimal.MaxValue;

            if (precoMin > precoMax)
            {
                return base.BadRequest("O preço mínimo não pode ser maior que o preço máximo");
            }

            var filtered = _produtoService.ListarProdutos(precoMin.Value, precoMax.Value);
            
            return base.Ok(filtered);
        }
        catch (Exception ex)
        {
            return base.StatusCode(500, new { Message = "Erro interno ao listar produtos.", Details = ex.Message });
        }
    }

    [HttpPost("CriarProduto")]
    [ProducesResponseType(typeof(Produto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Post([FromBody] Produto produto)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(produto.Id) ||
                string.IsNullOrWhiteSpace(produto.Marca) ||
                string.IsNullOrWhiteSpace(produto.Modelo) ||
                produto.Preco <= 0)
            {
                return base.BadRequest("Todos os campos são obrigatórios e o preço deve ser maior que zero.");
            }

            if (_produtoService.ObterProdutoPorId(produto.Id) != null)
            {
                return base.Conflict($"Já existe um produto com Id {produto.Id}.");
            }

            _produtoService.CriarProduto(produto);

            return base.Created();
        }
        catch (Exception ex)
        {
            return base.StatusCode(500, new { Message = "Erro interno ao criar o produto.", Details = ex.Message });
        }
    }

    [HttpPut("AtualizarProduto")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Put([FromBody] Produto produto)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(produto.Id))
            {
                return base.BadRequest("O ID do produto é obrigatório.");
            }
            
            if (_produtoService.ObterProdutoPorId(produto.Id) == null)
            {
                return base.NotFound("Produto não encontrado.");
            }

            _produtoService.AtualizarProduto(produto);
            
            return base.Ok("Produto atualizado com sucesso.");
        }
        catch (Exception ex)
        {
            return base.StatusCode(500, new { Message = "Erro interno ao atualizar o produto.", Details = ex.Message });
        }
    }

    [HttpDelete("RemoverProduto/{Id}")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Delete(string Id)
    {
        try
        {
            if (_produtoService.RemoverProduto(Id))
            {
                return Ok("Produto removido com sucesso.");
            }

            return NotFound("Produto não encontrado.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Message = "Erro interno ao remover o produto.", Details = ex.Message });
        }
    }
}
