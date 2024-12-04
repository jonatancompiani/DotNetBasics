using DotNetBasics.Aula06.Model;
using Microsoft.AspNetCore.Mvc;

namespace DotNetBasics.Aula06.Controllers;

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
        Produto? produto = produtos.Find(x => x.Id == Id);

        if(produto == null)
        {
            return base.NotFound();
        }

        return base.Ok(produto);
    }
    
    [HttpGet("ListarProduto")]
    [ProducesResponseType(typeof(IEnumerable<Produto>), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        return base.Ok(produtos);
    }

    [HttpPost("CriarProduto")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult Post([FromBody] Produto produto)
    {
        produtos.Add(produto);
        return base.Created();
    }

    [HttpPut("AtualizarProduto")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Put([FromBody] Produto produto)
    {
        int index = produtos.FindIndex(prod => prod.Id == produto.Id);
        if(index != -1)
        {
            produtos[index] = produto;
        }
        return base.Ok();
    }

    [HttpDelete("RemoverProduto/{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Delete(string Id)
    {
        int index = produtos.FindIndex(prod => prod.Id == Id);

        if (index != -1)
        {
            produtos.RemoveAt(index);
        }

        return base.Ok();
    }
}
