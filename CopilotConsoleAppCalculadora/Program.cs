using CopilotConsoleAppCalculadora.Models;

bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("=== CALCULADORA BÁSICA ===");

    double numero1, numero2;
    Console.Write("Digite o primeiro número: ");
    if (!double.TryParse(Console.ReadLine(), out numero1))
    {
        Console.WriteLine("Entrada inválida. Pressione qualquer tecla para tentar novamente.");
        Console.ReadKey();
        continue;
    }

    Console.Write("Digite o segundo número: ");
    if (!double.TryParse(Console.ReadLine(), out numero2))
    {
        Console.WriteLine("Entrada inválida. Pressione qualquer tecla para tentar novamente.");
        Console.ReadKey();
        continue;
    }

    Console.WriteLine("Escolha a operação:");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.Write("Opção: ");
    string opcao = Console.ReadLine();

    try
    {
        double resultado = opcao switch
        {
            "1" => Calculadora.Somar(numero1, numero2),
            "2" => Calculadora.Subtrair(numero1, numero2),
            "3" => Calculadora.Multiplicar(numero1, numero2),
            "4" => Calculadora.Dividir(numero1, numero2),
            _ => throw new InvalidOperationException("Operação inválida.")
        };

        Console.WriteLine($"Resultado: {resultado}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }

    Console.WriteLine("Deseja realizar outra operação? (s/n)");
    continuar = Console.ReadLine()?.Trim().ToLower() == "s";
}
