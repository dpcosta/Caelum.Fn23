# Exercício de Revisão
1. Crie um projeto Web vazio (Empty) com a referência de pastas do MVC.
1. Crie uma classe Produto na pasta Models. Essa classe terá os seguintes atributos: Id, Nome, Categoria e PrecoUnitario.
1. Crie uma funcionalidade que atenda a rota `Home/Index`. Essa funcionalidade deverá retornar uma página com o título "Loja Virtual Fn23".
1. Crie uma funcionalidade que atenda a rota `Produtos`. Essa funcionalidade deverá retornar a seguinte lista (fixa) de produtos:

| Id | Nome | Preço | Categoria |
|---|---|---|---|
| 1 | Leite | 3,45 | Bebidas |
| 2 | Biscoito Maizena | 4,99 | Alimentos |
| 3 | Chocolate em pó | 7,62 | Alimentos |
| 4 | Suco de Uva | 14,89 | Bebidas |
1. Crie um banco de dados chamado Loja e crie uma tabela Produtos com os produtos acima.
1. Crie uma string de conexão no arquivo de configuração da aplicação.
1. Substitua a listagem fixa por uma consulta à tabela de produtos recém-criada.