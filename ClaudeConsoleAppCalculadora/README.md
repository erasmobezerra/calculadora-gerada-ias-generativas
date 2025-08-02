## Passos para Executar o Projeto

1. **Criar o projeto:**
   ```bash
   dotnet new console -n ConsoleAppCalculadora
   cd ConsoleAppCalculadora
   ```

2. **Criar a estrutura de pastas:**
   ```bash
   mkdir Models
   ```

3. **Substituir o conte�do dos arquivos:**
   - Substitua o conte�do do arquivo `Program.cs` pelo c�digo fornecido
   - Crie o arquivo `Models/Calculadora.cs` com o c�digo da classe

4. **Executar o projeto:**
   ```bash
   dotnet run
   ```

## Explica��o Did�tica do Funcionamento

### **Program.cs (Programa Principal)**

O `Program.cs` � o ponto de entrada da aplica��o e cont�m toda a l�gica de intera��o com o usu�rio:

**1. Loop Principal:**
- Um `while (continuar)` mant�m o programa rodando at� o usu�rio escolher sair
- A cada itera��o, mostra o menu de op��es e aguarda a escolha do usu�rio

**2. Valida��o de Entrada:**
- Verifica se a op��o escolhida � v�lida (1-5)
- Usa `double.TryParse()` para converter strings em n�meros, validando se s�o n�meros v�lidos
- Trata o caso especial da divis�o por zero antes de chamar o m�todo

**3. Tratamento de Erros:**
- `try-catch` captura erros inesperados
- Valida��es espec�ficas para entradas inv�lidas
- Mensagens claras de erro para o usu�rio

**4. Interface Amig�vel:**
- `Console.Clear()` limpa a tela para melhor experi�ncia
- `Console.ReadKey()` pausa para o usu�rio ver o resultado
- Formata��o clara dos resultados com s�mbolos matem�ticos

### **Models/Calculadora.cs (Classe de C�lculos)**

A classe `Calculadora` � est�tica e respons�vel apenas pelos c�lculos:

**1. Classe Est�tica:**
- `static class` significa que n�o precisa ser instanciada
- Todos os m�todos s�o acessados diretamente: `Calculadora.Somar()`

**2. Propriedades Privadas:**
- `_operando1` e `_operando2` armazenam os valores utilizados
- S�o `private static` - apenas a pr�pria classe pode acess�-las

**3. M�todos de Opera��o:**
- Cada m�todo recebe dois par�metros `double`
- Armazena os valores nas propriedades privadas
- Retorna o resultado da opera��o matem�tica correspondente

**4. Separa��o de Responsabilidades:**
- A classe se preocupa apenas com os c�lculos
- N�o possui l�gica de interface ou valida��o
- Segue o princ�pio da responsabilidade �nica

Esta estrutura torna o c�digo organizado, f�cil de manter e extens�vel para futuras opera��es matem�ticas!