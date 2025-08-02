using DeepSeekConsoleAppCalculadora.Models;

bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("Calculadora Console - Operações Básicas");
    Console.WriteLine("--------------------------------------");

    try
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("\nOperações disponíveis:");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.Write("\nEscolha uma operação (1-4): ");

        int operacao = int.Parse(Console.ReadLine()!);
        double resultado = 0;
        string simboloOperacao = "";

        switch (operacao)
        {
            case 1:
                resultado = Calculadora.Somar(num1, num2);
                simboloOperacao = "+";
                break;

            case 2:
                resultado = Calculadora.Subtrair(num1, num2);
                simboloOperacao = "-";
                break;

            case 3:
                resultado = Calculadora.Multiplicar(num1, num2);
                simboloOperacao = "*";
                break;

            case 4:
                resultado = Calculadora.Dividir(num1, num2);
                simboloOperacao = "/";
                break;

            default:
                Console.WriteLine("Operação inválida!");
                continue;
        }

        Console.WriteLine($"\nResultado: {num1} {simboloOperacao} {num2} = {resultado}");
    }
    catch (FormatException)
    {
        Console.WriteLine("\nErro: Entrada inválida. Digite apenas números!");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"\nErro: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nOcorreu um erro inesperado: {ex.Message}");
    }

    Console.Write("\nDeseja realizar outra operação? (S/N): ");
    continuar = Console.ReadLine()!.Trim().ToUpper() == "S";
}

Console.WriteLine("\nObrigado por usar a calculadora!");