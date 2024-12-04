using DotNetBasics.Aula05.Model;
using Microsoft.AspNetCore.Mvc;

namespace DotNetBasics.Aula05.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private static readonly List<Produto> produtos = [];
    
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
}
