# Sistema de Finanças Pessoais

## Objetivo

Trabalho desenvolvido para a Disciplina Desenvolvimento de Sistemas II, do Curso de Desenvolvimento de Sistemas do SENAI Bahia, em junho de 2021.

## Descrição do Projeto

* Cadastro dos gastos (receitas, despesas fixas e variáveis); 
* Manter o controle de suas finanças ao longo do ano.

### Classes

* Usuário: Cadastra novo usuário; 
* Finança: Essa classe se relaciona com todas as outras classes e possui entrada de valor e data da transação; 
* Tipo; 
    - Receita: entradas de valores;
    - Despesa Variável: saídas que podem variar a cada mês: lazer, transporte, alimentação;
    - Despesa Fixa: saídas que tem mesmo valor a cada mês, como aluguel, internet, telefone, etc;
* Categoria: representa a natureza da transação: lazer, transporte, alimentação, salário, etc; 
* Modalidade: representa a forma de pagamento ou recebimento, como transferências, PIX, dinheiro, cartão, etc.
