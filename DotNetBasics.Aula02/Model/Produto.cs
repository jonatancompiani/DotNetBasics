namespace DotNetBasics.Aula02.Model;

public class Produto(string marca, string modelo, decimal preco)
{
    public string Marca { get; set; } = marca;
    public string Modelo { get; set; } = modelo;
    public decimal Preco { get; set; } = preco;

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Preço: {Preco:C}");
    }

    public decimal CalcularDesconto(decimal percentualDesconto)
    {
        return Preco - Preco * (percentualDesconto / 100);
    }
}
