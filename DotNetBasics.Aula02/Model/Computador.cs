namespace DotNetBasics.Aula02.Model;

public class Computador(string marca, string modelo, decimal preco, int memoria, string cpu)
    : Produto(marca, modelo, preco)
{
    public int GbMemoria { get; set; } = memoria;
    public string CPU { get; set; } = cpu;

    public override void ExibirDetalhes()
    {
        Console.WriteLine("Computador");
        base.ExibirDetalhes();
        Console.WriteLine($"Memória: {GbMemoria}GB");
        Console.WriteLine($"CPU: {CPU}");
    }
}