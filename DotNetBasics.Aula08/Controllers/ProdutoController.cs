using Microsoft.AspNetCore.Mvc;
using DotNetBasics.Aula08.Model;

namespace DotNetBasics.Aula08.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private static readonly List<Produto> produtos = [];

    [HttpGet("LerProduto/{Id}")]
    [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Get(string Id)
    {
        try
        {
            Produto? produto = produtos.Find(x => x.Id == Id);

            if (produto == null)
            {
                return base.NotFound("Produto não encontrado.");
            }

            return base.Ok(produto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Message = "Erro interno ao buscar o produto.", Details = ex.Message });
        }
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

            IEnumerable<Produto> filtered = produtos.Where(prod => prod.Preco >= precoMin && prod.Preco <= precoMax);

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

            if (produtos.Exists(x => x.Id == produto.Id))
            {
                return base.Conflict($"Já existe um produto com Id {produto.Id}.");
            }
            
            produtos.Add(produto);

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

            int index = produtos.FindIndex(prod => prod.Id == produto.Id);
            if (index == -1)
            {
                return base.NotFound("Produto não encontrado.");
            }

            produtos[index] = produto;
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
            int index = produtos.FindIndex(prod => prod.Id == Id);

            if (index == -1)
            {
                return NotFound("Produto não encontrado.");
            }

            produtos.RemoveAt(index);
            return Ok("Produto removido com sucesso.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Message = "Erro interno ao remover o produto.", Details = ex.Message });
        }
    }
}
