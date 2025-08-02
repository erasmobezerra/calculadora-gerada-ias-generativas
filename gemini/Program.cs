using GeminiConsoleAppCalculadora.Models;

Console.WriteLine("Bem-vindo à Calculadora de Operações Básicas!");
bool continuar = true;

while (continuar)
{
    Console.WriteLine("\nEscolha uma operação:");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("0 - Sair");

    Console.Write("Digite sua opção: ");
    string? opcao = Console.ReadLine();

    if (opcao == "0")
    {
        continuar = false;
        Console.WriteLine("Obrigado por usar a calculadora! Até mais.");
        break;
    }

    if (!int.TryParse(opcao, out int operacaoNumerica) || operacaoNumerica < 1 || operacaoNumerica > 4)
    {
        Console.WriteLine("Opção inválida. Por favor, digite um número entre 1 e 4 para as operações ou 0 para sair.");
        continue;
    }

    double num1, num2;

    Console.Write("Digite o primeiro número: ");
    while (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número válido para o primeiro operando.");
        Console.Write("Digite o primeiro número: ");
    }

    Console.Write("Digite o segundo número: ");
    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um número válido para o segundo operando.");
        Console.Write("Digite o segundo número: ");
    }

    double resultado = 0;
    bool calculoValido = true;

    switch (operacaoNumerica)
    {
        case 1:
            resultado = Calculadora.Somar(num1, num2);
            break;
        case 2:
            resultado = Calculadora.Subtrair(num1, num2);
            break;
        case 3:
            resultado = Calculadora.Multiplicar(num1, num2);
            break;
        case 4:
            try
            {
                resultado = Calculadora.Dividir(num1, num2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                calculoValido = false;
            }
            break;
    }

    if (calculoValido)
    {
        Console.WriteLine($"\nResultado: {resultado}");
    }

    Console.WriteLine("\nPressione qualquer tecla para continuar ou 0 para sair.");
    string? continuarOpcao = Console.ReadLine();
    if (continuarOpcao == "0")
    {
        continuar = false;
        Console.WriteLine("Obrigado por usar a calculadora! Até mais.");
    }
}