

-----

## Código-Fonte da Aplicação de Calculadora

Aqui está o código C\# completo para a sua aplicação de console:

```csharp
// Program.cs
using System;
using ConsoleAppCalculadora.Models;

namespace ConsoleAppCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
```

-----

```csharp
// Models/Calculadora.cs
using System;

namespace ConsoleAppCalculadora.Models
{
    public static class Calculadora
    {
        // Propriedades privadas para armazenar os operandos (embora não estritamente necessárias para métodos estáticos puros)
        // private static double _operando1;
        // private static double _operando2;

        public static double Somar(double num1, double num2)
        {
            // _operando1 = num1;
            // _operando2 = num2;
            return num1 + num2;
        }

        public static double Subtrair(double num1, double num2)
        {
            // _operando1 = num1;
            // _operando2 = num2;
            return num1 - num2;
        }

        public static double Multiplicar(double num1, double num2)
        {
            // _operando1 = num1;
            // _operando2 = num2;
            return num1 * num2;
        }

        public static double Dividir(double num1, double num2)
        {
            // _operando1 = num1;
            // _operando2 = num2;
            if (num2 == 0)
            {
                throw new DivideByZeroException("Erro: Não é possível dividir por zero.");
            }
            return num1 / num2;
        }
    }
}
```

-----

## Passos para Executar o Projeto em Seu Computador

Para executar este projeto, siga os passos abaixo:

1.  **Crie um novo projeto de Console App (.NET 8):**

      * Abra o **Visual Studio** ou o **Visual Studio Code**.
      * Crie um novo projeto do tipo "Console App" (Aplicativo de Console).
      * Certifique-se de que a **estrutura de pastas** seja algo como: `ConsoleAppCalculadora` (nome da solução e do projeto).

2.  **Crie a pasta "Models":**

      * Dentro do projeto `ConsoleAppCalculadora`, clique com o botão direito e selecione "Adicionar" -\> "Nova Pasta".
      * Nomeie a pasta como `Models`.

3.  **Crie o arquivo "Calculadora.cs" na pasta "Models":**

      * Clique com o botão direito na pasta `Models` e selecione "Adicionar" -\> "Novo Item..." -\> "Classe".
      * Nomeie a classe como `Calculadora.cs`.

4.  **Copie e cole o código:**

      * **Substitua o conteúdo** do arquivo `Program.cs` pelo primeiro bloco de código fornecido acima.
      * **Substitua o conteúdo** do arquivo `Models/Calculadora.cs` pelo segundo bloco de código fornecido acima.

5.  **Restaure as dependências (se necessário) e Compile:**

      * No Visual Studio, pressione `Ctrl + Shift + B` ou vá em "Build" -\> "Build Solution".
      * No Visual Studio Code, abra o terminal (`Ctrl + ~`) e digite `dotnet build`.

6.  **Execute a aplicação:**

      * No Visual Studio, pressione `F5` ou clique no botão "Iniciar" (geralmente um triângulo verde).
      * No Visual Studio Code, no terminal, digite `dotnet run`.

A aplicação será executada no console, permitindo que você interaja com a calculadora.

-----

## Funcionamento do Código

Vamos detalhar como cada parte do código funciona, especialmente para quem está começando:

### 1\. `Models/Calculadora.cs`

Esta é a nossa **classe de lógica de negócios** para as operações matemáticas.

  * **`public static class Calculadora`**:

      * `public`: Significa que esta classe pode ser acessada de qualquer lugar do seu projeto.
      * `static`: Esta é a parte crucial. Uma classe estática não pode ser instanciada (você não pode criar um "objeto" `new Calculadora()`). Em vez disso, você acessa seus membros (métodos) diretamente usando o nome da classe, como `Calculadora.Somar()`. Isso é ideal para utilitários que não precisam manter um estado específico para cada "instância".
      * `class`: Palavra-chave que define uma classe.

  * **Métodos Estáticos (`Somar`, `Subtrair`, `Multiplicar`, `Dividir`)**:

      * `public static double NomeDoMetodo(double num1, double num2)`:
          * `public static`: Assim como a classe, os métodos são `public` (acessíveis de fora) e `static` (podem ser chamados diretamente pela classe).
          * `double`: É o **tipo de retorno** do método. Significa que esses métodos sempre retornarão um número com casas decimais (ponto flutuante).
          * `num1`, `num2`: São os **parâmetros** que os métodos recebem. Eles representam os números nos quais a operação será realizada.
      * **Lógica de Operação**: Cada método simplesmente executa a operação matemática correspondente e retorna o resultado.
      * **Tratamento de Divisão por Zero (`Dividir` método)**:
          * `if (num2 == 0)`: Antes de tentar a divisão, verificamos se o segundo número (`num2`) é zero.
          * `throw new DivideByZeroException("Erro: Não é possível dividir por zero.")`: Se `num2` for zero, lançamos uma **exceção**. Uma exceção é um sinal de que algo inesperado e problemático aconteceu. Neste caso, é um erro de divisão por zero, que o C\# já possui um tipo específico (`DivideByZeroException`). Lançar uma exceção interrompe o fluxo normal do programa naquele ponto e permite que a parte que chamou o método (o `Program.cs` neste caso) lide com o erro.

  * **Propriedades Comentadas**: As propriedades `_operando1` e `_operando2` estão comentadas. Embora a especificação mencionasse que a classe *poderia* conter propriedades protegidas ou privadas, para métodos estáticos que recebem todos os seus dados via parâmetros, armazenar operandos em propriedades estáticas é desnecessário e poderia levar a confusão se a classe fosse chamada concorrentemente em um ambiente multi-threaded. Remover essa complexidade torna o código mais limpo para este cenário.

### 2\. `Program.cs`

Este é o **ponto de entrada** da sua aplicação. É aqui que toda a interação com o usuário acontece e onde chamamos os métodos da classe `Calculadora`.

  * **`using ConsoleAppCalculadora.Models;`**: Esta linha é crucial. Ela "importa" o **namespace** onde a sua classe `Calculadora` está localizada. Sem ela, o `Program.cs` não saberia onde encontrar a classe `Calculadora`.
  * **`static void Main(string[] args)`**: Este é o **método principal** que é executado quando o programa inicia.
      * `static`: Indica que este método pertence à classe `Program` em si, não a uma instância específica.
      * `void`: Significa que o método `Main` não retorna nenhum valor.
      * `string[] args`: Permite passar argumentos de linha de comando para o programa, embora não os estejamos usando aqui.
  * **`Console.WriteLine()` e `Console.Write()`**:
      * Usados para **exibir texto** na tela do console. `WriteLine` adiciona uma nova linha após o texto, enquanto `Write` não.
  * **`Console.ReadLine()`**:
      * Usado para **ler a entrada do usuário** do console. Ele sempre retorna uma `string`.
  * **`bool continuar = true;` e `while (continuar)`**:
      * Isso cria um **loop principal** que mantém a calculadora em execução até que o usuário decida sair. A variável `continuar` controla a condição de saída do loop.
  * **Leitura da Opção do Usuário e Validação**:
      * `string? opcao = Console.ReadLine();`: Lê a opção desejada pelo usuário (somar, subtrair, etc.). O `?` indica que a string pode ser nula (embora `ReadLine` raramente retorne nulo em aplicativos de console típicos).
      * `if (!int.TryParse(opcao, out int operacaoNumerica) || operacaoNumerica < 1 || operacaoNumerica > 4)`:
          * `int.TryParse(opcao, out int operacaoNumerica)`: Esta é uma forma **segura** de tentar converter uma `string` para um `int`. Se a conversão for bem-sucedida, ele retorna `true` e armazena o número na variável `operacaoNumerica`. Se falhar (por exemplo, se o usuário digitar "abc"), ele retorna `false`.
          * `!int.TryParse(...)`: O `!` (operador NOT) inverte o resultado. Então, se a conversão *não* for bem-sucedida (ou seja, `TryParse` retorna `false`), a condição se torna `true`.
          * `|| operacaoNumerica < 1 || operacaoNumerica > 4`: Adiciona uma verificação para garantir que o número digitado esteja dentro do intervalo de opções válidas (1 a 4).
          * Se a entrada for inválida, uma mensagem de erro é exibida e `continue` faz o loop pular para a próxima iteração, pedindo a opção novamente.
  * **Leitura dos Números e Validação (`while (!double.TryParse(...))`)**:
      * Semelhante à validação da opção, usamos `double.TryParse()` para converter as entradas do usuário para números de ponto flutuante (`double`).
      * O `while` loop garante que o programa só prossiga quando o usuário digitar um número válido. Se a entrada for inválida, ele continua pedindo até que um número correto seja fornecido.
  * **`switch (operacaoNumerica)`**:
      * Esta estrutura é usada para executar diferentes blocos de código com base no valor da variável `operacaoNumerica`. É uma alternativa mais limpa a múltiplos `if-else if` para esse cenário.
  * **Chamada dos Métodos da Calculadora**:
      * `resultado = Calculadora.Somar(num1, num2);`: É assim que chamamos os métodos estáticos da nossa classe `Calculadora`. Não precisamos criar um objeto `Calculadora`. Simplesmente usamos `NomeDaClasse.NomeDoMetodo(argumentos)`.
  * **Tratamento de Erros de Divisão por Zero (`try-catch`)**:
      * `try { ... } catch (DivideByZeroException ex) { ... }`: Este é um bloco **try-catch**.
          * O código dentro do bloco `try` é monitorado para possíveis exceções.
          * Se uma `DivideByZeroException` (como a que lançamos na classe `Calculadora`) for lançada dentro do `try` e for capturada pelo `catch`, o código dentro do bloco `catch` será executado.
          * `ex.Message`: A propriedade `Message` da exceção contém a mensagem que definimos quando lançamos a exceção ("Erro: Não é possível dividir por zero.").
          * `calculoValido = false;`: Uma flag é definida para evitar que o programa tente exibir um resultado inválido após uma divisão por zero.
  * **Exibição do Resultado**:
      * `Console.WriteLine($"\nResultado: {resultado}");`: Exibe o resultado da operação. O `$""` é uma **string interpolada**, que permite incorporar variáveis diretamente dentro da string.
  * **Opção de Continuar ou Sair**:
      * Após cada cálculo, o programa pergunta ao usuário se ele deseja continuar ou sair, e o loop `while` principal se ajusta de acordo.

Em resumo, o `Program.cs` atua como a **interface do usuário** e o **orquestrador**, enquanto a classe `Calculadora.cs` encapsula a **lógica matemática pura**, mantendo o código organizado e modular.