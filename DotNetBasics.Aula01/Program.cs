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
    
    string[] partes = input.Split('+');

    double numero1 = Convert.ToDouble(partes[0]);
    double numero2 = Convert.ToDouble(partes[1]);
    double resultado = numero1 + numero2;

    Console.WriteLine($"Resultado: {resultado}");
    Console.WriteLine("Deseja realizar outra operação? (s/n): ");
    input = Console.ReadLine().ToLower();

} while (input == "s");