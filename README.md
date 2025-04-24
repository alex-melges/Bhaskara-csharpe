# Fórmula de Bhaskara

Este projeto implementa a fórmula de Bhaskara para o cálculo das raízes de uma equação do segundo grau da forma:

ax² + bx + c = 0

## Como funciona?

O programa solicita ao usuário os valores dos coeficientes **a**, **b** e **c**. Ele garante que o coeficiente **a** não seja nulo, pois uma equação do segundo grau não pode ter **a** igual a zero. O programa, então, calcula o discriminante (Δ) e determina as raízes com base no valor de Δ:

- **Se Δ > 0**: Existem duas raízes reais e distintas.
- **Se Δ = 0**: Existe uma única raiz real (raízes iguais).
- **Se Δ < 0**: Existem duas raízes complexas conjugadas.

### Exemplo de Execução

Ao rodar o programa, o usuário verá a seguinte saída:

=== Fórmula de Bhaskara para o cálculo de raízes de polinômios de 2º grau ===

A equação do segundo grau tem a forma: ax² + bx + c = 0 Informe os coeficientes abaixo:

Digite o coeficiente a (não pode ser nulo): 1 Digite o coeficiente b: -3 Digite o coeficiente c: 2

Discriminante (Δ) = 1 As raízes reais são: x1 = 2 x2 = 1


## Como executar

1. Clone o repositório ou baixe os arquivos para o seu computador.
2. Abra o terminal na pasta onde os arquivos estão localizados.
3. Compile e execute o programa usando o seguinte comando:

```bash
dotnet run
```

O programa solicitará os coeficientes a, b e c, calculará as raízes e exibirá o resultado no terminal.

## Arquivos
- **Bhaskara.cs:** Implementação do cálculo das raízes de uma equação de segundo grau utilizando a fórmula de Bhaskara.
- **Bhaskara.csproj:** Arquivo de configuração do projeto, necessário para compilar e rodar a aplicação.

## Ferramentas e Tecnologias Utilizadas
- **C#:** Linguagem principal utilizada para a implementação do programa.
- **.NET SDK:** Framework utilizado para compilar e executar o projeto (versão 9.0).