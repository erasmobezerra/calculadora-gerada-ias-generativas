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
