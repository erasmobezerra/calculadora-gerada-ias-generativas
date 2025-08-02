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