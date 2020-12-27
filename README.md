# Rob� API

## Problema a ser desenvolvido

Desenvolvimento de uma interface para controlar os movimentos de um Rob�.
Para isso, os controles devem ser realizados atrav�s de uma API Web RESTful capaz de visualizar 
os estados atuais do Rob� e enviar comandos para que este assuma novos estados.

## A��es previstas para o Rob�

**Bra�os**

|Bra�o Esquerdo            |Bra�o Direito             |
|--------------------------|--------------------------|
| Cotovelo                 | Cotovelo                 |
|  1. Em Repouso           |  1. Em Repouso           |
|  2. Levemente Contra�do  |  2. Levemente Contra�do  |
|  3. Contra�do            |  3. Contra�do            |
|  4. Fortemente Contra�do |  4. Fortemente Contra�do |
| Pulso                    | Pulso                    |
|  1. -90�                 |  1. -90�                 |
|  2. -45�                 |  2. -45�                 |
|  3. Em Repouso           |  3. Em Repouso           |
|  4. 45�                  |  4. 45�                  |
|  5. 90�                  |  5. 90�                  |
|  6. 135�                 |  6. 135�                 |
|  7. 180�                 |  7. 180�                 |

**Cabe�a**

|Rota��o                   |Inclina��o                |
|--------------------------|--------------------------|
| 1. -90�                  | 1. -90�                  |
| 2. -45�                  | 2. -45�                  |
| 3. Em Repouso            | 3. Em Repouso            |
| 4. 45�                   | 4. 45�                   |
| 5. 90�                   | 5. 90�                   |

## Restri��es para o funcionamento do Rob�

- O estado inicial dos movimentos � Em Repouso;
- S� poder� movimentar o Pulso caso o Cotovelo esteja Fortemente Contra�do;
- S� poder� Rotacionar a Cabe�a caso sua Inclina��o da Cabe�a n�o esteja em estado Para Baixo;
- Ao realizar a progress�o de estados, � necess�rio que sempre siga a ordem crescente ou decrescente, 
por exemplo, a partir do estado 4, pode-se ir para os estados 3 ou 5, nunca pulando um estado.