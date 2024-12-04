/*
    Aula 2: Conceitos básicos de Orientação a Objetos e Classes em C#

    Aplicação Prática:
        Crie uma classe Produto com as propriedades Marca, Modelo e Preço. 
        Escreva métodos para exibir os detalhes do produto e calcular um desconto, 
        esta classe deverá ser herdada por duas classes, uma classe Tela com as propriedades 
        Resolucao e Tamanho, e outra classe Computador, com as própriedades Memória e CPU.
        Ao fim, será possível invocar um método que irá imprimir os detalhes do produto, 
        e um método que irá imprimir o preço
 */


using DotNetBasics.Aula02.Model;

Tela tela = new ("Samsung", "UltraHD", 1500m, "3840x2160", 27);
Computador computador = new ("Dell", "Inspiron", 4500m, 16, "Intel i7");

tela.ExibirDetalhes();
Console.WriteLine($"Preço com desconto: {tela.CalcularDesconto(10):C}");
Console.WriteLine();

computador.ExibirDetalhes();
Console.WriteLine($"Preço com desconto: {computador.CalcularDesconto(15):C}");
Console.WriteLine();
