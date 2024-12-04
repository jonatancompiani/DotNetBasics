namespace DotNetBasics.Aula02.Model;

public class Tela(string marca, string modelo, decimal preco, string resolucao, double tamanho)
    : Produto(marca, modelo, preco)
{
    public string Resolucao { get; set; } = resolucao;
    public double Tamanho { get; set; } = tamanho;

    public override void ExibirDetalhes()
    {
        Console.WriteLine("Tela");
        base.ExibirDetalhes();
        Console.WriteLine($"Resolução: {Resolucao}");
        Console.WriteLine($"Tamanho: {Tamanho} polegadas");
    }
}