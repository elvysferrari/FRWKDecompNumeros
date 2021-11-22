# FRWKDecompNumeros

Desafio Técnico - .NET

Descrição do Desafio

1. Um cliente precisa de um sistema que seja capaz de decompor um número em todos os seus divisores, enumerando também aqueles que forem primos.

Obs.: Não é permitido o uso de bibliotecas prontas, se houver, que façam a decomposição.

● Dado um número de entrada, o programa deve calcular todos os divisores que compõem o número.

● Dado um número de entrada, o programa deve calcular todos os divisores primos que compõem o número.


2. Já temos nossa funcionalidade principal. Contudo, você acaba de descobrir que essa funcionalidade vai ser usada em outros sistemas e, por isso, é necessário que seja disponibilizada um serviço que forneça as informações. Fique atento a:

● Performance

● Escalabilidade

● Disponibilidade

● Resiliência

● Robustez

Tecnologias utilizadas no desenvolvimento do desafio
- Visual Studio 2022 Current ( Versão 17.0.1 )
- SDK .NET 6.0
- Padrão de projeto DDD com Teste Unitário (xUnit)
- GitHub como respositório dos fontes

Como testar:
- Atualizar o Visual Studio para versão acima (2022 - 17.0.1 ) e instalar SDK .NET 6.0
- Fazer o download ou clone dos arquivos deste projeto GIT
- Abrir o VS definir o projeto APIs/FRWKDecompNumerosAPI como o de inicialização caso necessário
- Rodar o projeto e aguardar abrir a página do swagger (https://localhost:7121/swagger/index.html)
- Utilizar o endpoint /api/decompnumero/{numero} para informar os números
- Para testes unitários abrir o gerenciador de testes (CTRL + E, T) e rodá-los, projeto de testes se encontra em Testes/Teste/DecompNumeroTeste






