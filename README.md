# Nome Do Projeto

Este projeto tem como objetivo calcular as principais métricas de um retângulo a partir de sua largura e altura, exibindo **área**, **perímetro** e **diagonal**.

Este projeto foi desenvolvido de forma incremental, registrando a evolução do código em uma abordagem **orientada a objetos**.

## Conceitos Trabalhados

- Leitura e exibição de dados via console
- Modelagem de entidades simples
- Encapsulamento de dados e comportamentos
- Criação de métodos para regras de negócio
- Cálculo de valores derivados a partir de atributos
- Organização e versionamento de código com Git

## Enunciado do Problema

Fazer um programa para ler os valores da **largura** e **altura** de um retângulo. Em seguida, mostrar na tela:

- O valor da área
- O valor do perímetro
- O valor da diagonal

## Estrutura do Projeto

```bash
|- MetricasRetangulo
  |- Src
    |- IO
      |- RetanguloInputs.cs
      |- RetanguloOutputs.cs
    |- Rentagulo.cs
    |- RetanguloExemplos.cs
  |- MetricasRetangulo.csproj
  |- MetricasRetangulo.sln
  |- Program.cs
```

*(A estrutura pode evoluir conforme o aprendizado avança.)*

## Evolução do Projeto (Tags)

**Conceitos aplicados**:

- **Classes:** [v0.1][1] — Classe Retangulo com override de ToString

**Evolução Estrutural:** 

- [v0.1.1][2] — Reorganização estrutural e inclusão de nome
- [v0.1.2][3] — Reorganização por camadas (Domínio, IO e Exemplos)

## Objetivo Educacional

Este projeto **não tem como foco a solução final perfeita**, mas sim o processo de aprendizado e a comparação entre abordagens diferentes para o mesmo problema.

[1]: https://github.com/jspneto/csharp-estudos-metricas-de-um-retangulo/tree/v0.1.2/MetricasRetangulo "v0.1"

[2]: https://github.com/jspneto/csharp-estudos-metricas-de-um-retangulo/tree/v0.1.1/MetricasRetangulo "v0.1"

[3]: https://github.com/jspneto/csharp-estudos-metricas-de-um-retangulo/tree/v0.1.2/MetricasRetangulo "v0.1"