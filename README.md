### Introdução
Ao longo do curso, iremos aprender conceitos básicos da linguagem de programação, assim como o necessário para começar a desenvolver e manter projetos reais. O curso consiste de **10 aulas práticas** onde, ao fim de cada uma, o conteúdo apresentado será aplicado a um cenário do mundo real.

---

### Planejamento de Aulas

#### **Aula 1: Introdução ao .NET e Fundamentos de C#**
Configuração do ambiente de desenvolvimento e compreensão fundamental do **.NET 8** e do **C#**, incluindo variáveis, tipos de dados e estruturas básicas de controle, como condicionais e loops. Esta aula estabelece a base para escrever programas simples em C# e prepara para conceitos mais avançados.

**Aplicação Prática:**  
Escreva um programa simples em C# que realiza operações matemáticas de soma. O programa deve apresentar o título “Calculadora” e solicitar ao usuário a operação. O usuário poderá digitar algo como `10+15`, e o programa exibirá o resultado, perguntando se ele deseja realizar outro cálculo. Em caso negativo, a aplicação encerrará a execução; caso positivo, ela exibirá novamente o título e solicitará uma nova operação.

---

#### **Aula 2: Conceitos Básicos de Orientação a Objetos e Classes em C#**
Esta sessão introduz os princípios da programação orientada a objetos, com foco em classes, objetos e métodos. Os alunos criarão e interagirão com objetos, entendendo como estruturar o código usando classes. Esse conhecimento é essencial para construir aplicações mais complexas.

**Aplicação Prática:**  
Crie uma classe **Produto** com as propriedades **Marca**, **Modelo** e **Preço**. Escreva métodos para exibir os detalhes do produto e calcular um desconto. Esta classe será herdada por duas classes:  
- **Tela:** com propriedades **Resolução** e **Tamanho**  
- **Computador:** com as propriedades **Memória** e **CPU**  

Ao final, será possível invocar um método que imprime os detalhes do produto e outro que imprime o preço.

---

#### **Aula 3: Introdução às Web APIs e HTTP**
O que são APIs e como elas funcionam. Criação do primeiro projeto de Web API com **.NET 8**, incluindo controladores e protocolo **HTTP** (métodos **GET** e **POST**). Ao final da aula, os alunos terão uma Web API básica em funcionamento localmente.

**Aplicação Prática:**  
Crie uma Web API básica com um endpoint que receba os dados de uma operação matemática e retorne o resultado.

---

#### **Aula 4: Manipulação de Dados com C# e APIs**
Esta aula foca na manipulação de dados em **C#**. Os alunos trabalharão com listas e arrays, aprendendo a usar coleções para gerenciar dados. A criação de um endpoint na API retornará dados em formato **JSON**, introduzindo o conceito de serialização de dados.

**Aplicação Prática:**  
Crie uma API que retorna uma lista de produtos em formato JSON.

---

#### **Aula 5: Model Binding e Transferência de Dados**
Introdução ao **Model Binding** em Web APIs, que mapeia dados de requisições HTTP para objetos C#. Os alunos criarão modelos de dados e manipularão entradas e saídas em formato **JSON**. Esta aula enfatiza a importância de estruturar e transferir dados entre clientes e servidores.

**Aplicação Prática:**  
Expanda a API de produtos para aceitar dados de produtos via requisição **POST**, e retornar os produtos criados via **GET**.

---

#### **Aula 6: Operações CRUD Simples**
Implementação de operações **CRUD** básicas — Criar, Ler, Atualizar e Deletar — em Web APIs. Os alunos aprenderão a gerenciar e manipular dados por meio de métodos HTTP, construindo endpoints que realizam essas ações fundamentais.

**Aplicação Prática:**  
Implemente a funcionalidade CRUD básica na API de produtos (por exemplo, endpoints para adicionar, visualizar, atualizar e excluir produtos).

---

#### **Aula 7: Introdução ao Tratamento de Erros**
Esta sessão apresenta o tratamento de erros em **C#** usando blocos **try-catch**. Os alunos aprenderão a gerenciar e responder a erros de forma elegante em suas APIs, o que é crucial para criar aplicações robustas que lidam com situações inesperadas sem falhar.

**Aplicação Prática:**  
Adicione tratamento básico de erros à API de produtos para gerenciar entradas inválidas ou dados ausentes.

---

#### **Aula 8: Entendendo Rotas e Parâmetros de Consulta**
Esta aula cobre o roteamento em Web APIs, incluindo como passar parâmetros através de URLs e usar **strings de consulta**. Os alunos criarão rotas dinâmicas para recuperar e filtrar dados, adicionando flexibilidade ao design da API.

**Aplicação Prática:**  
Adicione um endpoint para recuperar um produto pelo **ID** e outro para filtrar produtos por **preço**.

---

#### **Aula 9: Introdução à Injeção de Dependência (DI)**
Introdução ao conceito de **injeção de dependência (DI)**, fundamental no **.NET**. Os alunos entenderão como criar serviços e injetá-los nos controladores, promovendo um código mais limpo e fácil de manter.

**Aplicação Prática:**  
Crie um serviço simples para gerenciamento de produtos e injete-o no controlador.

---

#### **Aula 10: Noções Básicas de Testes e Recapitulação do Projeto**
Introdução a testes unitários em **C#** usando **xUnit**. Os alunos escreverão testes simples para a API e revisarão todos os conceitos abordados no curso, validando o código e compreendendo o processo completo de desenvolvimento de APIs.

**Aplicação Prática:**  
Escreva testes unitários simples para a API de produtos e revise o projeto para garantir que todas as operações **CRUD** funcionem corretamente.
