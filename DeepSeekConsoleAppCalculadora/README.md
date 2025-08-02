## 💡 Prompt utilizado

```
[PERSONA] 
Atue como um desenvolvedor .NET sênior especializado em aplicações de console e design de classes.

[OBJETIVO CLARO / FINALIDADE] 
Crie um código-fonte completo em C# para uma aplicação de Console (.NET 8) que funcione como uma calculadora de operações básicas. A calculadora deve permitir ao usuário realizar as seguintes operações: Somar, Subtrair, Multiplicar, Dividir.

[DETALHES DA TAREFA A SER EXECUTADA]
**Interação com o Usuário:
A aplicação deve interagir com o usuário via console, solicitando os números e a operação desejada. Após cada cálculo, o resultado deve ser exibido, e o usuário deve ter a opção de realizar outra operação ou sair do programa.

**Estrutura do Código: 
=>Classe Estática Calculadora:
-Deve estar localizada em uma pasta Models dentro do projeto.
-Será uma classe static.
-Conterá os métodos estaticos para cada operação (Somar, Subtrair, Multiplicar, Dividir).
-Pode conter propriedades protegidas ou privadas para armazenar os operandos.

=> Arquivo Program.cs (Programa Principal):
-Deve conter a lógica de interação com o usuário (leitura de entrada, exibição de resultados, loop de operações).
-Chamar os métodos de operação para os cálculos.
-Inclua tratamento de erros para entradas inválidas (não numéricas) e para divisão por zero.
-Não é necessário a inclusão de comentário no código.

[FORMATO DE SAIDA ESPERADO] 
Estrutura da Resposta Esperada: 
-Forneça o código C# completo em blocos de código separados para o Program.cs e a classe Models > Calculadora.cs, pronto para ser copiado para um projeto de console .NET. 
-Forneça os passos para quem desejar executar o projeto em seu computador.
-Conclua explicando o funcionamento do código no Pogram.cs  Calculadora.cs de uma forma didática para entendimento de quem está inciando os estudos
```

---

## Retorno do Prompt no Copilot

---

# Calculadora Console em .NET 8

## Estrutura do Projeto

```
CalculadoraConsole/
ÃÄÄ Models/
³   ÀÄÄ Calculadora.cs
ÀÄÄ Program.cs
```

## C¢digo Fonte

### 1. Calculadora.cs

```csharp
namespace CalculadoraConsole.Models;

public static class Calculadora
{
    public static double Somar(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double Subtrair(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double Multiplicar(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double Dividir(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("N„o ‚ poss¡vel dividir por zero!");
        }
        return num1 / num2;
    }
}
```

### 2. Program.cs

```csharp
using CalculadoraConsole.Models;

bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("Calculadora Console - Opera‡”es B sicas");
    Console.WriteLine("--------------------------------------");
    
    try
    {
        Console.Write("Digite o primeiro n£mero: ");
        double num1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo n£mero: ");
        double num2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("\nOpera‡”es dispon¡veis:");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.Write("\nEscolha uma opera‡„o (1-4): ");
        
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
                Console.WriteLine("Opera‡„o inv lida!");
                continue;
        }

        Console.WriteLine($"\nResultado: {num1} {simboloOperacao} {num2} = {resultado}");
    }
    catch (FormatException)
    {
        Console.WriteLine("\nErro: Entrada inv lida. Digite apenas n£meros!");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"\nErro: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nOcorreu um erro inesperado: {ex.Message}");
    }

    Console.Write("\nDeseja realizar outra opera‡„o? (S/N): ");
    continuar = Console.ReadLine()!.Trim().ToUpper() == "S";
}

Console.WriteLine("\nObrigado por usar a calculadora!");
```

## Passos para Execu‡„o

1. Crie um novo projeto Console em .NET 8:
   ```bash
   dotnet new console -n CalculadoraConsole
   cd CalculadoraConsole
   ```

2. Crie a pasta `Models` e adicione o arquivo `Calculadora.cs` com o c¢digo fornecido

3. Substitua o conte£do do `Program.cs` pelo c¢digo fornecido

4. Execute o projeto:
   ```bash
   dotnet run
   ```

## Explica‡„o Did tica

### Calculadora.cs

Esta ‚ uma classe est tica que cont‚m os m‚todos para as opera‡”es matem ticas b sicas:

1. **M‚todos Est ticos**: Cada opera‡„o (Somar, Subtrair, Multiplicar, Dividir) ‚ implementada como um m‚todo est tico, o que significa que podem ser chamados sem precisar criar uma instƒncia da classe.

2. **Tratamento de Erros**: O m‚todo `Dividir` inclui uma verifica‡„o para divis„o por zero, lan‡ando uma exce‡„o espec¡fica nesse caso.

3. **Simplicidade**: Cada m‚todo faz apenas uma coisa espec¡fica, seguindo o princ¡pio de responsabilidade £nica.

### Program.cs

Este ‚ o ponto de entrada da aplica‡„o e cont‚m a l¢gica de intera‡„o com o usu rio:

1. **Loop Principal**: O programa roda em um loop `while` que continua at‚ o usu rio decidir sair.

2. **Entrada de Dados**: Solicita dois n£meros e a opera‡„o desejada ao usu rio.

3. **Tratamento de Exce‡”es**:
   - `FormatException`: Captura entradas n„o num‚ricas
   - `DivideByZeroException`: Trata tentativas de divis„o por zero
   - `Exception`: Captura quaisquer outros erros inesperados

4. **Estrutura de Controle**: Usa um `switch` para determinar qual opera‡„o matem tica executar com base na escolha do usu rio.

5. **Feedback Visual**: Mostra a opera‡„o realizada e seu resultado no formato "num1 operador num2 = resultado".

6. **Continuidade**: Pergunta ao usu rio se deseja realizar outra opera‡„o antes de continuar ou sair.

Esta estrutura separa claramente a l¢gica de c lculo (na classe Calculadora) da intera‡„o com o usu rio (no Program.cs), seguindo boas pr ticas de desenvolvimento.