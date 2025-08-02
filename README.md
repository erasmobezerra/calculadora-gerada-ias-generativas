
## Calculadora com .NET 8 gerada por IAs Generativas

### 🎯 Objetivo <br>
Comparar as respostas geradas por diferentes IAs generativas a partir de um mesmo prompt inicial.

## 📚 Contexto <br>
Com base nos conhecimentos adquiridos no módulo de Engenharia de Prompt do bootcamp da Deal Group, 
decidi compartilhar alguns projetos iniciais que desenvolvi utilizando IAs generativas — como o 
Copilot da Microsoft — para criar uma calculadora simples em C#.

## 📁 Sobre o Repositório <br>
Este repositório contém quatro projetos, cada um com código gerado por uma IA diferente: Gemini, 
Copilot, Claude e ChatGPT. Embora o prompt utilizado seja o mesmo (detalhado abaixo), cada modelo 
produziu soluções distintas, com variações de estilo e estrutura.
 
## 💡 Prompt utilizado nos projetos

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

## 🧩 Como produzir um bom prompt?
O modelo que utilizei acima é um exemplo de como estruturar um prompt eficaz para gerar código com IAs generativas.
É um modelo que pode ser adaptando de infinitas formas para diferentes projetos e linguagens de programação.
A seguir estão os principais componentes e técnicas que você pode aplicar para criar prompts de alta qualidade


### 🧠 Componentes de um Prompt Eficaz

| **Componente**              | **Descrição**                                                                 | **Exemplo**                                                                                   |
|----------------------------|------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------|
| **Instrução Clara e Concisa** | Define com precisão o que a LLM deve fazer. Use verbos de ação e evite ambiguidades. | “Gere uma lista de 5 raças de cachorros populares e suas principais características.”         |
| **Contexto Relevante**       | Fornece informações adicionais para orientar a resposta. Pode incluir histórico ou cenário. | “Inclua o artigo completo para gerar um resumo.” ou “Descreva o problema detalhadamente.”     |
| **Formato Desejado**         | Especifica como a resposta deve ser estruturada: lista, parágrafo, código, tabela etc. | “Gere uma resposta em formato de lista numerada.” ou “Forneça o código Python para...”        |
| **Restrições e Condições**   | Define limites como número de palavras, tom da resposta ou tópicos a evitar. | “A resposta deve ter no máximo 100 palavras.” ou “Mantenha um tom profissional.”              |
| **Exemplos (Few-shot)**      | Fornece exemplos de entrada e saída para orientar o modelo.                 | “Maçã → Fruta”, “Cenoura → Vegetal”, “Leão → ?”                                               |
| **Persona (Opcional)**       | Define um papel ou especialização que a LLM deve assumir.                   | “Você é um nutricionista. Forneça conselhos sobre dieta.” ou “Atue como especialista em marketing.” |

---

### 🧪 Principais Técnicas de Engenharia de Prompt

* **Zero-shot Prompting:**
    * **O que é:** É a forma mais básica. Você pede algo à LLM sem fornecer nenhum exemplo prévio. Ela usa o conhecimento que já possui.
    * **Quando usar:** Para tarefas simples e diretas, quando a LLM já tem um bom entendimento do que você está pedindo.
    * **Exemplo:** "Traduza 'hello' para o português."

* **Few-shot Prompting:**
    * **O que é:** Você fornece um ou mais exemplos de pares de entrada e saída para a LLM antes de fazer sua pergunta real. Isso a ajuda a aprender o padrão desejado.
    * **Quando usar:** Para tarefas que exigem um formato específico, um estilo particular ou que a LLM precisa inferir um padrão. É excelente para adaptar a LLM a tarefas mais complexas.
    * **Exemplo:** 
        "Estou tão feliz com a notícia!" → Alegria | "Não consigo parar de chorar desde que ele se foi." → Tristeza  
       

* **Chain-of-Thought (CoT) Prompting:**
    * **O que é:** Instruir a LLM a "pensar alto" ou a mostrar seus passos de raciocínio antes de dar a resposta final. Isso é feito adicionando frases como "Vamos pensar passo a passo" ou "Explique seu raciocínio".
    * **Quando usar:** Para problemas complexos de raciocínio lógico, matemática, ou quando a resposta exige múltiplos passos. Melhora drasticamente a capacidade da LLM de resolver problemas complexos.
    * **Exemplo:** "João tem 5 maçãs e Maria tem o dobro. Se eles comerem 3 maçãs juntos, quantas maçãs sobrarão? Pense passo a passo."

* **Self-Consistency (Consistência Própria):**
    * **O que é:** Uma extensão do CoT. A LLM gera várias cadeias de pensamento diferentes para a mesma pergunta e, em seguida, seleciona a resposta final que aparece com mais frequência ou que é mais lógica entre todas as cadeias.
    * **Quando usar:** Para aumentar a robustez e precisão em problemas muito desafiadores de raciocínio, onde a LLM pode ter várias abordagens válidas para chegar à solução. É mais computacionalmente intensivo.
    * **Exemplo:** "Para resolver este problema matemático, gere três soluções diferentes e escolha a mais consistente entre elas."

* * **Generated Knowledge Prompting (Geração de Conhecimento):**
    * **O que é:** A LLM primeiro gera informações relevantes (conhecimento) sobre o tópico da pergunta e, em seguida, usa esse conhecimento gerado para responder à pergunta original.
    * **Quando usar:** Quando a pergunta é muito específica ou exige conhecimento detalhado que pode não estar prontamente disponível na memória direta da LLM, mas que ela pode inferir ou compilar.
    * **Exemplo:** "Primeiro, liste os principais benefícios do exercício físico. Em seguida, com base nessa lista, crie um plano de treino semanal para um iniciante."

* **Retrieval-Augmented Generation (RAG) Prompting:**
    * **O que é:** Combina a LLM com um sistema de recuperação de informações. Antes de a LLM gerar uma resposta, o sistema RAG busca documentos ou dados relevantes de uma base de conhecimento externa e os fornece como contexto para a LLM.
    * **Quando usar:** Para perguntas que exigem informações muito específicas, atualizadas ou proprietárias que a LLM não tem em seu treinamento original. Essencial para aplicações corporativas e chatbots que precisam de dados em tempo real.
    * **Exemplo:** (Prompt para o sistema RAG): "Busque no banco de dados da empresa as políticas de férias. (Prompt para a LLM, com as políticas recuperadas): Com base nas políticas de férias fornecidas, explique como um funcionário pode solicitar férias."

* **Persona Prompting:**
    * **O que é:** Atribuir uma "personalidade" ou "papel" à LLM para que ela responda de uma perspectiva específica.
    * **Quando usar:** Para adaptar o tom, o estilo e o tipo de informação fornecida ao público-alvo ou à finalidade.
    * **Exemplo:** "Você é um professor de história. Explique a Revolução Francesa de forma didática para alunos do ensino médio."

---

### ❓ Por Que Essas Técnicas São Importantes?

Essas técnicas são cruciais porque as LLMs, por mais avançadas que sejam, não são oniscientes nem adivinhos. Elas precisam de direção. Ao aplicar essas estratégias, você:

🎯 **Melhora a Precisão:** Reduz a chance de respostas incorretas ou irrelevantes.
📌 **Aumenta a Relevância:** Garante que a LLM se concentre no que é importante para você.
🚀 **Otimiza o Desempenho:** Ajuda a LLM a lidar com tarefas mais complexas e sutis.
🧾 **Garante o Formato Desejado:** Recebe as informações no layout que você precisa.

Dominar a engenharia de prompt é, portanto, uma habilidade fundamental para extrair o máximo potencial das LLMs em diversas aplicações.

-----

### 💡 Dicas Adicionais para um Bom Prompt

⚖️ **Seja Específico, mas Não Excessivamente Restritivo:** Encontre um equilíbrio. Um prompt muito vago resultará em respostas genéricas, enquanto um excessivamente restritivo pode limitar a criatividade da LLM. <br>
🧩 **Divida Tarefas Complexas:** Se a tarefa for muito complexa, divida-a em etapas menores e use vários prompts para cada etapa. <br>
🔄 **Itere e Experimente:** Dificilmente você criará o prompt perfeito na primeira tentativa. Experimente diferentes formulações e observe como a LLM responde. Ajuste e refine conforme necessário. <br>
🗣️ **Use Linguagem Clara e Simples:** Evite jargões desnecessários ou frases excessivamente complexas que possam confundir a LLM. <br>


---

### 🧑‍💻 Modelo de Prompt para Criação de Programa Simples


```
Atue como um programador experiente.

Você vai me ajudar a criar um programa.

Linguagem de Programação Desejada: [INSERIR LINGUAGEM DE PROGRAMAÇÃO AQUI, ex: Python, JavaScript, Java, C#]

Tipo de Programa/Funcionalidade: [DESCREVER O QUE O PROGRAMA DEVE FAZER. Seja o mais específico possível. Ex: "Calcular a área de um círculo", "Converter Celsius para Fahrenheit", "Gerar uma lista de números pares entre 1 e 20", "Implementar uma função de busca em um array", "Criar um jogo simples de adivinhação de números".]

Requisitos Específicos (Opcional, mas recomendado):
* Entrada de Usuário: [ESPECIFICAR SE O PROGRAMA DEVE INTERAGIR COM O USUÁRIO E COMO. Ex: "Deve solicitar ao usuário o raio do círculo", "Deve pedir ao usuário para adivinhar um número".]
* Saída Esperada: [ESPECIFICAR COMO A SAÍDA DEVE SER APRESENTADA. Ex: "Deve exibir o resultado formatado com duas casas decimais", "Deve imprimir cada número par em uma nova linha", "Deve informar se o palpite está correto, muito alto ou muito baixo".]
* Condições/Restrições Adicionais: [QUALQUER OUTRA CONDIÇÃO. Ex: "Não deve usar bibliotecas externas, apenas funcionalidades nativas", "Deve incluir tratamento de erro para entradas inválidas", "Deve ter comentários explicativos no código".]
* Estrutura do Código (Opcional): [SE HOUVER PREFERÊNCIA POR FUNÇÕES, CLASSES, ETC. Ex: "A funcionalidade principal deve estar dentro de uma função chamada 'calcular_area'", "Deve ser organizado em classes se a linguagem suportar".]
* Nível de complexidade desejado: [Ex: iniciante, intermediário, avançado]
* Ambiente de execução: [Ex: terminal, navegador, IDE específica]
* Estilo de resposta: [Ex: direto ao ponto, explicativo, passo a passo]

Sua Tarefa:
1.  Forneça o código completo e funcional para o programa descrito, na linguagem de programação especificada.
2.  Inclua comentários claros no código para explicar as partes importantes ou complexas.
3.  Forneça um exemplo de como usar/executar o programa.
4.  Explique brevemente o raciocínio por trás da solução e como ela atende aos requisitos.
```


### 🧬 Como Este Modelo de Prompt Utiliza as Técnicas Discutidas:

1.  **Persona Prompting:** `**Atue como um programador experiente.**` Define o papel da LLM para garantir um tom e uma abordagem técnicos e profissionais.
2.  **Instrução Clara e Concisa:** As seções "Linguagem de Programação Desejada" e "Tipo de Programa/Funcionalidade" definem explicitamente o objetivo.
3.  **Contexto e Restrições Detalhadas:** A seção "Requisitos Específicos" permite que você adicione **restrições e condições** cruciais para a saída, como entrada/saída, tratamento de erros e estrutura. Isso também funciona como **instruções de formato desejado**.
4.  **Chain-of-Thought (Implícito no Resultado):** Embora não explicitamente solicitado como "pense passo a passo", o item "Explique brevemente **o raciocínio por trás da solução**" força a LLM a apresentar uma justificativa lógica, que é uma forma de CoT posterior à geração.
5.  **Exemplo de Uso (para clareza):** Pedir um "exemplo de como usar/executar o programa" é uma forma de **few-shot prompting indireto** ou uma instrução de **saída clara**, garantindo que você saiba como interagir com o código gerado.

---


