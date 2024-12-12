/*
    Aula 1: Introdução ao .NET e Fundamentos de C#

    Aplicação Prática: 
        Aplicação Prática: Escreva um programa simples em C# que realiza operações matemáticas de soma. 
        O programa deve apresentar o título “Calculadora”, e solicitar ao usuário a operação, 
        o usuário poderá digitar algo como “10+15” e o programa exibirá o resultado, e perguntará ao usuário 
        se ele deseja realizar outro cálculo, caso negativo, a aplicação irá terminar a execução, 
        em caso positivo, a aplicação irá exibir novamente o título e solicitar uma nova operação.
 */

string input;
do
{
    Console.Clear();
    Console.WriteLine("Calculadora");
    Console.Write("Digite a operação de soma (ex: 10+15): ");

    input = Console.ReadLine(); 
    
    string[] partes = input.Split('+');// 10+15 → [10,15]

    double numero1 = Convert.ToDouble(partes[0]);
    double numero2 = Convert.ToDouble(partes[1]);
    double resultado = numero1 + numero2;

    // string.Format("olá {0}, hoje é {1}", "luiz", "dia");
    
    Console.WriteLine($"Resultado: {resultado}");
    
    Console.WriteLine("Deseja realizar outra operação? (s/n): ");// s
    input = Console.ReadLine().ToLower();

} while (input == "s");


Console.WriteLine("Fim");

/*

Console.Write("Qual o valor do produto: ");
string input = Console.ReadLine();

decimal preco = decimal.Parse(input);
decimal desconto = CalcularDesconto(preco);



static decimal Soma(decimal val1, decimal val2)
{
    // ....
    
    return val1 + val2;
}



// retorno Nome (tipo nome)

static decimal CalcularDesconto(decimal preco)
{
    decimal desconto = 0m;
    if (preco > 100)
    {
        desconto = 20m;
    }
    else if (preco > 50)
    {
        desconto = 10m;
    }

    return desconto;
}
*/