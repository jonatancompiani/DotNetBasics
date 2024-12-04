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
                    return BadRequest("Divis�o por zero n�o permitida");
                }

                result = Numero1 / Numero2;
                break;

            default:
                return BadRequest("Opera��o inv�lida. use ( +, -, * ou / )");
        }

        return Ok(new { Result = result });
    }
}