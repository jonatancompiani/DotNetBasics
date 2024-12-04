using DotNetBasics.Aula04.Model;
using Microsoft.AspNetCore.Mvc;

namespace DotNetBasics.Aula04.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    [HttpGet("ListarProduto")]
    public IActionResult Get()
    {
        IEnumerable<Produto> produtos =
        [
            new (){ Marca = "LG", Modelo = "CCC", Preco = 10.5m },
            new (){ Marca = "Samsung", Modelo = "BBB", Preco = 20.0m },
            new (){ Marca = "Motorola", Modelo = "AAA", Preco = 15.4m },
            new (){ Marca = "Xiaomi", Modelo = "CBA", Preco = 9.15m },
            new (){ Marca = "Nokia", Modelo = "ABC", Preco = 12.8m },
        ];
        return base.Ok(produtos);
    }
}
