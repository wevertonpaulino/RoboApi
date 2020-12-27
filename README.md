# Robô API

## Problema a ser desenvolvido

Desenvolvimento de uma interface para controlar os movimentos de um Robô.
Para isso, os controles devem ser realizados através de uma API Web RESTful capaz de visualizar 
os estados atuais do Robô e enviar comandos para que este assuma novos estados.

## Ações previstas para o Robô

**Braços**

|Braço Esquerdo            |Braço Direito             |
|--------------------------|--------------------------|
| Cotovelo                 | Cotovelo                 |
|  1. Em Repouso           |  1. Em Repouso           |
|  2. Levemente Contraído  |  2. Levemente Contraído  |
|  3. Contraído            |  3. Contraído            |
|  4. Fortemente Contraído |  4. Fortemente Contraído |
| Pulso                    | Pulso                    |
|  1. -90º                 |  1. -90º                 |
|  2. -45º                 |  2. -45º                 |
|  3. Em Repouso           |  3. Em Repouso           |
|  4. 45º                  |  4. 45º                  |
|  5. 90º                  |  5. 90º                  |
|  6. 135º                 |  6. 135º                 |
|  7. 180º                 |  7. 180º                 |

**Cabeça**

|Rotação                   |Inclinação                |
|--------------------------|--------------------------|
| 1. -90º                  | 1. -90º                  |
| 2. -45º                  | 2. -45º                  |
| 3. Em Repouso            | 3. Em Repouso            |
| 4. 45º                   | 4. 45º                   |
| 5. 90º                   | 5. 90º                   |

## Restrições para o funcionamento do Robô

- O estado inicial dos movimentos é Em Repouso;
- Só poderá movimentar o Pulso caso o Cotovelo esteja Fortemente Contraído;
- Só poderá Rotacionar a Cabeça caso sua Inclinação da Cabeça não esteja em estado Para Baixo;
- Ao realizar a progressão de estados, é necessário que sempre siga a ordem crescente ou decrescente, 
por exemplo, a partir do estado 4, pode-se ir para os estados 3 ou 5, nunca pulando um estado.