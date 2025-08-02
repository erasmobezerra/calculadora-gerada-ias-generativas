using ClaudeConsoleAppCalculadora.Models;

public class Program
{
    private static string GetOperadorSimbolo(string opcao)
    {
        return opcao switch
        {
            "1" => "+",
            "2" => "-",
            "3" => "*",
            "4" => "/",
            _ => ""
        };
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("=== CALCULADORA CONSOLE ===");

        bool continuar = true;

        while (continuar)
        {
            try
            {
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine();

                if (opcao == "5")
                {
                    continuar = false;
                    Console.WriteLine("Encerrando calculadora...");
                    break;
                }

                if (!new[] { "1", "2", "3", "4" }.Contains(opcao))
                {
                    Console.WriteLine("Opção inválida! Escolha entre 1 e 5.");
                    continue;
                }

                Console.Write("Digite o primeiro número: ");
                string entrada1 = Console.ReadLine();

                Console.Write("Digite o segundo número: ");
                string entrada2 = Console.ReadLine();

                if (!double.TryParse(entrada1, out double numero1) ||
                    !double.TryParse(entrada2, out double numero2))
                {
                    Console.WriteLine("Erro: Digite apenas números válidos!");
                    continue;
                }

                double resultado = 0;
                string operacao = "";

                switch (opcao)
                {
                    case "1":
                        resultado = Calculadora.Somar(numero1, numero2);
                        operacao = "Soma";
                        break;

                    case "2":
                        resultado = Calculadora.Subtrair(numero1, numero2);
                        operacao = "Subtração";
                        break;

                    case "3":
                        resultado = Calculadora.Multiplicar(numero1, numero2);
                        operacao = "Multiplicação";
                        break;

                    case "4":
                        if (numero2 == 0)
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida!");
                            continue;
                        }
                        resultado = Calculadora.Dividir(numero1, numero2);
                        operacao = "Divisão";
                        break;
                }

                Console.WriteLine($"\n{operacao}: {numero1} {GetOperadorSimbolo(opcao)} {numero2} = {resultado}");

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}