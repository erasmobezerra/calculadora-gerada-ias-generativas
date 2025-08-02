
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

## Retorno do Prompt no Claude

---

Vou criar uma aplicação de console completa em C# .NET 8 para uma calculadora com as especificações solicitadas.## Passos para Executar o Projeto

### Program.cs 
```csharp
using ConsoleAppCalculadora.Models;

namespace ConsoleAppCalculadora
{
    class Program
    {
        static void Main(string[] args)
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
        
        static string GetOperadorSimbolo(string opcao)
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
    }
}
```

### Calculadora.cs
```csharp
namespace ConsoleAppCalculadora.Models
{
    public static class Calculadora
    {
        private static double _operando1;
        private static double _operando2;
        
        public static double Somar(double numero1, double numero2)
        {
            _operando1 = numero1;
            _operando2 = numero2;
            return _operando1 + _operando2;
        }
        
        public static double Subtrair(double numero1, double numero2)
        {
            _operando1 = numero1;
            _operando2 = numero2;
            return _operando1 - _operando2;
        }
        
        public static double Multiplicar(double numero1, double numero2)
        {
            _operando1 = numero1;
            _operando2 = numero2;
            return _operando1 * _operando2;
        }
        
        public static double Dividir(double numero1, double numero2)
        {
            _operando1 = numero1;
            _operando2 = numero2;
            return _operando1 / _operando2;
        }
    }
}

```


1. **Criar o projeto:**
   ```bash
   dotnet new console -n ConsoleAppCalculadora
   cd ConsoleAppCalculadora
   ```

2. **Criar a estrutura de pastas:**
   ```bash
   mkdir Models
   ```

3. **Substituir o conteúdo dos arquivos:**
   - Substitua o conteúdo do arquivo `Program.cs` pelo código fornecido
   - Crie o arquivo `Models/Calculadora.cs` com o código da classe

4. **Executar o projeto:**
   ```bash
   dotnet run
   ```

## Explicação Didática do Funcionamento

### **Program.cs (Programa Principal)**

O `Program.cs` é o ponto de entrada da aplicação e contém toda a lógica de interação com o usuário:

**1. Loop Principal:**
- Um `while (continuar)` mantém o programa rodando até o usuário escolher sair
- A cada iteração, mostra o menu de opções e aguarda a escolha do usuário

**2. Validação de Entrada:**
- Verifica se a opção escolhida é válida (1-5)
- Usa `double.TryParse()` para converter strings em números, validando se são números válidos
- Trata o caso especial da divisão por zero antes de chamar o método

**3. Tratamento de Erros:**
- `try-catch` captura erros inesperados
- Validações específicas para entradas inválidas
- Mensagens claras de erro para o usuário

**4. Interface Amigável:**
- `Console.Clear()` limpa a tela para melhor experiência
- `Console.ReadKey()` pausa para o usuário ver o resultado
- Formatação clara dos resultados com símbolos matemáticos

### **Models/Calculadora.cs (Classe de Cálculos)**

A classe `Calculadora` é estática e responsável apenas pelos cálculos:

**1. Classe Estática:**
- `static class` significa que não precisa ser instanciada
- Todos os métodos são acessados diretamente: `Calculadora.Somar()`

**2. Propriedades Privadas:**
- `_operando1` e `_operando2` armazenam os valores utilizados
- São `private static` - apenas a própria classe pode acessá-las

**3. Métodos de Operação:**
- Cada método recebe dois parâmetros `double`
- Armazena os valores nas propriedades privadas
- Retorna o resultado da operação matemática correspondente

**4. Separação de Responsabilidades:**
- A classe se preocupa apenas com os cálculos
- Não possui lógica de interface ou validação
- Segue o princípio da responsabilidade única

Esta estrutura torna o código organizado, fácil de manter e extensível para futuras operações matemáticas!