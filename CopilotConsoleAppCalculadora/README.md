
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

Claro, Erasmo! Aqui está um projeto completo de ConsoleApp em C# (.NET 8) que implementa uma calculadora básica com estrutura organizada e interação amigável via terminal.

---

## 🗂 Estrutura do Projeto

```
ConsoleCalculadora/
│
├── Models/
│   └── Calculadora.cs
│
└── Program.cs
```

---

## 📄 Models/Calculadora.cs

```csharp
namespace ConsoleCalculadora.Models
{
    public static class Calculadora
    {
        private static double _numero1;
        private static double _numero2;

        public static double Somar(double numero1, double numero2)
        {
            _numero1 = numero1;
            _numero2 = numero2;
            return _numero1 + _numero2;
        }

        public static double Subtrair(double numero1, double numero2)
        {
            _numero1 = numero1;
            _numero2 = numero2;
            return _numero1 - _numero2;
        }

        public static double Multiplicar(double numero1, double numero2)
        {
            _numero1 = numero1;
            _numero2 = numero2;
            return _numero1 * _numero2;
        }

        public static double Dividir(double numero1, double numero2)
        {
            _numero1 = numero1;
            _numero2 = numero2;

            if (_numero2 == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");

            return _numero1 / _numero2;
        }
    }
}
```

---

## 📄 Program.cs

```csharp
using ConsoleCalculadora.Models;

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
```

---

## 🧪 Como Executar o Projeto

1. **Pré-requisitos**:
   - Instale o [.NET SDK 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
   - Um editor como Visual Studio, VS Code ou Rider

2. **Passos**:
   - Crie um novo projeto de console:
     ```bash
     dotnet new console -n ConsoleCalculadora
     cd ConsoleCalculadora
     ```
   - Crie a pasta `Models`:
     ```bash
     mkdir Models
     ```
   - Adicione o conteúdo de `Calculadora.cs` dentro da pasta `Models`
   - Substitua o conteúdo de `Program.cs` pelo código acima
   - Execute o projeto:
     ```bash
     dotnet run
     ```

---

## 🧠 Explicação Didática

### 🔹 `Calculadora.cs`
- É uma **classe estática**, ou seja, não precisa ser instanciada.
- Contém métodos para cada operação matemática.
- Usa campos privados `_numero1` e `_numero2` para armazenar os valores temporariamente (boa prática para encapsulamento).
- O método `Dividir` lança uma exceção se o divisor for zero, evitando erro de execução.

### 🔹 `Program.cs`
- Controla o **fluxo principal** do programa.
- Usa `TryParse` para validar se a entrada é numérica.
- Apresenta um menu de operações e executa a escolhida com `switch expression`.
- Usa `try/catch` para capturar erros como divisão por zero ou operação inválida.
- Após cada operação, pergunta ao usuário se deseja continuar.

---

Se quiser evoluir esse projeto, podemos adicionar suporte a operações com múltiplos números, histórico de cálculos, ou até uma interface gráfica com WinForms ou WPF. Quer seguir por esse caminho?
