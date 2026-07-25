# TesteDeIdades

Um sistema de processamento de dados desenvolvido em C# (.NET 8), solicitado como teste técnico para vaga de estágio. Tem como foco uma validação de idades, retornando o nome das Pessoas de maior e menor idade, com auxílio do laço de repetição foreach

## Tecnologias e Dependências

Para executar este projeto, o seu ambiente de desenvolvimento precisa atender aos seguintes requisitos:

- **Linguagem:** C# 12
- **Framework:** .NET 8.0 SDK (Obrigatório para compilação e execução)
- **Ambiente:** Qualquer terminal (PowerShell, Bash, CMD) ou IDE (VS Code, Visual Studio)

## Instruções de Instalação e Execução

Este projeto foi arquitetado de forma com que o código de produção fique isolado dentro do diretório `src`.

1. **Clone o repositório** para a sua máquina local:

   ```bash
   git clone https://github.com/karoupng/teste-karol.git
   ```

2. **Navegue até a pasta do código-fonte:**
   O comando de execução não funcionará na raiz do repositório. Você precisa entrar na pasta onde o projeto (arquivo `.csproj`) está localizado:

   ```bash
   cd src/TesteDeIdades
   ```

3. **Execute a aplicação:**
   ```bash
   dotnet run
   ```

## Uso de IA

Conforme diretrizes do teste técnico, declaro abaixo a utilização de assistência de Inteligência Artificial durante o desenvolvimento deste projeto.

- **Se utilizou IA:** Sim.
- **Para quê utilizou:** A IA foi utilizada exclusivamente como mentora técnica e guia de boas práticas de Engenharia de Software (Programação em pares, me ajudou na organização da arquitetura das pastas), visando adequar o repositório aos padrões exigidos pelo mercado corporativo.
- **Quais partes do código foram geradas ou auxiliadas por IA:** Foram desenvolvidos de forma autoral: lógica matemática, a criação das variáveis e a estruturação da classe `Pessoa`. A IA auxiliou ativamente na **Refatoração da Árvore de Diretórios**, sugerindo o isolamento do código na pasta `src`, na instrução dos comandos de terminal (`CLI`) para criar e vincular o arquivo `Solution` (`.sln`).
- **O que você entendeu e o que você ajustou manualmente:** Entendi a importância de não misturar arquivos de configuração global com o código de produção. Compreendi que o compilador C# gera arquivos pesados (`bin` e `obj`) que não devem ser versionados. Ajustei manualmente a exclusão física dessas pastas, movi os arquivos para a nova arquitetura `src`, renomeei o projeto para TesteDeIdades para melhorar a clareza do objetivo e realizei os commits através do GitHub Desktop para maior praticidade.

## Referências de Boas Práticas

A estruturação desta documentação foi baseada e inspirada nos padrões corporativos apresentados em:

- [Best Practical README Guidelines (v6.0.3)](https://docs.bestpractical.com/rt/6.0.3/README.html)
