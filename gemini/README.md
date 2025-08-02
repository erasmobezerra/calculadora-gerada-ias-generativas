

-----

## C�digo-Fonte da Aplica��o de Calculadora

Aqui est� o c�digo C\# completo para a sua aplica��o de console:

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
            Console.WriteLine("Bem-vindo � Calculadora de Opera��es B�sicas!");
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nEscolha uma opera��o:");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("0 - Sair");

                Console.Write("Digite sua op��o: ");
                string? opcao = Console.ReadLine();

                if (opcao == "0")
                {
                    continuar = false;
                    Console.WriteLine("Obrigado por usar a calculadora! At� mais.");
                    break;
                }

                if (!int.TryParse(opcao, out int operacaoNumerica) || operacaoNumerica < 1 || operacaoNumerica > 4)
                {
                    Console.WriteLine("Op��o inv�lida. Por favor, digite um n�mero entre 1 e 4 para as opera��es ou 0 para sair.");
                    continue;
                }

                double num1, num2;

                Console.Write("Digite o primeiro n�mero: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Entrada inv�lida. Por favor, digite um n�mero v�lido para o primeiro operando.");
                    Console.Write("Digite o primeiro n�mero: ");
                }

                Console.Write("Digite o segundo n�mero: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Entrada inv�lida. Por favor, digite um n�mero v�lido para o segundo operando.");
                    Console.Write("Digite o segundo n�mero: ");
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
                    Console.WriteLine("Obrigado por usar a calculadora! At� mais.");
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
        // Propriedades privadas para armazenar os operandos (embora n�o estritamente necess�rias para m�todos est�ticos puros)
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
                throw new DivideByZeroException("Erro: N�o � poss�vel dividir por zero.");
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
      * Certifique-se de que a **estrutura de pastas** seja algo como: `ConsoleAppCalculadora` (nome da solu��o e do projeto).

2.  **Crie a pasta "Models":**

      * Dentro do projeto `ConsoleAppCalculadora`, clique com o bot�o direito e selecione "Adicionar" -\> "Nova Pasta".
      * Nomeie a pasta como `Models`.

3.  **Crie o arquivo "Calculadora.cs" na pasta "Models":**

      * Clique com o bot�o direito na pasta `Models` e selecione "Adicionar" -\> "Novo Item..." -\> "Classe".
      * Nomeie a classe como `Calculadora.cs`.

4.  **Copie e cole o c�digo:**

      * **Substitua o conte�do** do arquivo `Program.cs` pelo primeiro bloco de c�digo fornecido acima.
      * **Substitua o conte�do** do arquivo `Models/Calculadora.cs` pelo segundo bloco de c�digo fornecido acima.

5.  **Restaure as depend�ncias (se necess�rio) e Compile:**

      * No Visual Studio, pressione `Ctrl + Shift + B` ou v� em "Build" -\> "Build Solution".
      * No Visual Studio Code, abra o terminal (`Ctrl + ~`) e digite `dotnet build`.

6.  **Execute a aplica��o:**

      * No Visual Studio, pressione `F5` ou clique no bot�o "Iniciar" (geralmente um tri�ngulo verde).
      * No Visual Studio Code, no terminal, digite `dotnet run`.

A aplica��o ser� executada no console, permitindo que voc� interaja com a calculadora.

-----

## Funcionamento do C�digo

Vamos detalhar como cada parte do c�digo funciona, especialmente para quem est� come�ando:

### 1\. `Models/Calculadora.cs`

Esta � a nossa **classe de l�gica de neg�cios** para as opera��es matem�ticas.

  * **`public static class Calculadora`**:

      * `public`: Significa que esta classe pode ser acessada de qualquer lugar do seu projeto.
      * `static`: Esta � a parte crucial. Uma classe est�tica n�o pode ser instanciada (voc� n�o pode criar um "objeto" `new Calculadora()`). Em vez disso, voc� acessa seus membros (m�todos) diretamente usando o nome da classe, como `Calculadora.Somar()`. Isso � ideal para utilit�rios que n�o precisam manter um estado espec�fico para cada "inst�ncia".
      * `class`: Palavra-chave que define uma classe.

  * **M�todos Est�ticos (`Somar`, `Subtrair`, `Multiplicar`, `Dividir`)**:

      * `public static double NomeDoMetodo(double num1, double num2)`:
          * `public static`: Assim como a classe, os m�todos s�o `public` (acess�veis de fora) e `static` (podem ser chamados diretamente pela classe).
          * `double`: � o **tipo de retorno** do m�todo. Significa que esses m�todos sempre retornar�o um n�mero com casas decimais (ponto flutuante).
          * `num1`, `num2`: S�o os **par�metros** que os m�todos recebem. Eles representam os n�meros nos quais a opera��o ser� realizada.
      * **L�gica de Opera��o**: Cada m�todo simplesmente executa a opera��o matem�tica correspondente e retorna o resultado.
      * **Tratamento de Divis�o por Zero (`Dividir` m�todo)**:
          * `if (num2 == 0)`: Antes de tentar a divis�o, verificamos se o segundo n�mero (`num2`) � zero.
          * `throw new DivideByZeroException("Erro: N�o � poss�vel dividir por zero.")`: Se `num2` for zero, lan�amos uma **exce��o**. Uma exce��o � um sinal de que algo inesperado e problem�tico aconteceu. Neste caso, � um erro de divis�o por zero, que o C\# j� possui um tipo espec�fico (`DivideByZeroException`). Lan�ar uma exce��o interrompe o fluxo normal do programa naquele ponto e permite que a parte que chamou o m�todo (o `Program.cs` neste caso) lide com o erro.

  * **Propriedades Comentadas**: As propriedades `_operando1` e `_operando2` est�o comentadas. Embora a especifica��o mencionasse que a classe *poderia* conter propriedades protegidas ou privadas, para m�todos est�ticos que recebem todos os seus dados via par�metros, armazenar operandos em propriedades est�ticas � desnecess�rio e poderia levar a confus�o se a classe fosse chamada concorrentemente em um ambiente multi-threaded. Remover essa complexidade torna o c�digo mais limpo para este cen�rio.

### 2\. `Program.cs`

Este � o **ponto de entrada** da sua aplica��o. � aqui que toda a intera��o com o usu�rio acontece e onde chamamos os m�todos da classe `Calculadora`.

  * **`using ConsoleAppCalculadora.Models;`**: Esta linha � crucial. Ela "importa" o **namespace** onde a sua classe `Calculadora` est� localizada. Sem ela, o `Program.cs` n�o saberia onde encontrar a classe `Calculadora`.
  * **`static void Main(string[] args)`**: Este � o **m�todo principal** que � executado quando o programa inicia.
      * `static`: Indica que este m�todo pertence � classe `Program` em si, n�o a uma inst�ncia espec�fica.
      * `void`: Significa que o m�todo `Main` n�o retorna nenhum valor.
      * `string[] args`: Permite passar argumentos de linha de comando para o programa, embora n�o os estejamos usando aqui.
  * **`Console.WriteLine()` e `Console.Write()`**:
      * Usados para **exibir texto** na tela do console. `WriteLine` adiciona uma nova linha ap�s o texto, enquanto `Write` n�o.
  * **`Console.ReadLine()`**:
      * Usado para **ler a entrada do usu�rio** do console. Ele sempre retorna uma `string`.
  * **`bool continuar = true;` e `while (continuar)`**:
      * Isso cria um **loop principal** que mant�m a calculadora em execu��o at� que o usu�rio decida sair. A vari�vel `continuar` controla a condi��o de sa�da do loop.
  * **Leitura da Op��o do Usu�rio e Valida��o**:
      * `string? opcao = Console.ReadLine();`: L� a op��o desejada pelo usu�rio (somar, subtrair, etc.). O `?` indica que a string pode ser nula (embora `ReadLine` raramente retorne nulo em aplicativos de console t�picos).
      * `if (!int.TryParse(opcao, out int operacaoNumerica) || operacaoNumerica < 1 || operacaoNumerica > 4)`:
          * `int.TryParse(opcao, out int operacaoNumerica)`: Esta � uma forma **segura** de tentar converter uma `string` para um `int`. Se a convers�o for bem-sucedida, ele retorna `true` e armazena o n�mero na vari�vel `operacaoNumerica`. Se falhar (por exemplo, se o usu�rio digitar "abc"), ele retorna `false`.
          * `!int.TryParse(...)`: O `!` (operador NOT) inverte o resultado. Ent�o, se a convers�o *n�o* for bem-sucedida (ou seja, `TryParse` retorna `false`), a condi��o se torna `true`.
          * `|| operacaoNumerica < 1 || operacaoNumerica > 4`: Adiciona uma verifica��o para garantir que o n�mero digitado esteja dentro do intervalo de op��es v�lidas (1 a 4).
          * Se a entrada for inv�lida, uma mensagem de erro � exibida e `continue` faz o loop pular para a pr�xima itera��o, pedindo a op��o novamente.
  * **Leitura dos N�meros e Valida��o (`while (!double.TryParse(...))`)**:
      * Semelhante � valida��o da op��o, usamos `double.TryParse()` para converter as entradas do usu�rio para n�meros de ponto flutuante (`double`).
      * O `while` loop garante que o programa s� prossiga quando o usu�rio digitar um n�mero v�lido. Se a entrada for inv�lida, ele continua pedindo at� que um n�mero correto seja fornecido.
  * **`switch (operacaoNumerica)`**:
      * Esta estrutura � usada para executar diferentes blocos de c�digo com base no valor da vari�vel `operacaoNumerica`. � uma alternativa mais limpa a m�ltiplos `if-else if` para esse cen�rio.
  * **Chamada dos M�todos da Calculadora**:
      * `resultado = Calculadora.Somar(num1, num2);`: � assim que chamamos os m�todos est�ticos da nossa classe `Calculadora`. N�o precisamos criar um objeto `Calculadora`. Simplesmente usamos `NomeDaClasse.NomeDoMetodo(argumentos)`.
  * **Tratamento de Erros de Divis�o por Zero (`try-catch`)**:
      * `try { ... } catch (DivideByZeroException ex) { ... }`: Este � um bloco **try-catch**.
          * O c�digo dentro do bloco `try` � monitorado para poss�veis exce��es.
          * Se uma `DivideByZeroException` (como a que lan�amos na classe `Calculadora`) for lan�ada dentro do `try` e for capturada pelo `catch`, o c�digo dentro do bloco `catch` ser� executado.
          * `ex.Message`: A propriedade `Message` da exce��o cont�m a mensagem que definimos quando lan�amos a exce��o ("Erro: N�o � poss�vel dividir por zero.").
          * `calculoValido = false;`: Uma flag � definida para evitar que o programa tente exibir um resultado inv�lido ap�s uma divis�o por zero.
  * **Exibi��o do Resultado**:
      * `Console.WriteLine($"\nResultado: {resultado}");`: Exibe o resultado da opera��o. O `$""` � uma **string interpolada**, que permite incorporar vari�veis diretamente dentro da string.
  * **Op��o de Continuar ou Sair**:
      * Ap�s cada c�lculo, o programa pergunta ao usu�rio se ele deseja continuar ou sair, e o loop `while` principal se ajusta de acordo.

Em resumo, o `Program.cs` atua como a **interface do usu�rio** e o **orquestrador**, enquanto a classe `Calculadora.cs` encapsula a **l�gica matem�tica pura**, mantendo o c�digo organizado e modular.