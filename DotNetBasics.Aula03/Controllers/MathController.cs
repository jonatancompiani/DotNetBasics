using Microsoft.AspNetCore.Mvc;

namespace DotNetBasics.Aula03.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MathController : ControllerBase
{
    [HttpGet("calcular")]
    public IActionResult Calculate(decimal Numero1, decimal Numero2, string Operacao)
    {
        decimal result;
        switch (Operacao.ToLower())
        {
            case "+":
                result = Numero1 + Numero2;
                break;

            case "-":
                result = Numero1 - Numero2;
                break;

            case "*":
                result = Numero1 * Numero2;
                break;

            case "/":
                if (Numero2 == 0m)
                {
                    return BadRequest("Divisão por zero não permitida");
                }

                result = Numero1 / Numero2;
                break;

            default:
                return BadRequest("Operação inválida. use ( +, -, * ou / )");
        }

        return Ok(new { Result = result });
    }
}