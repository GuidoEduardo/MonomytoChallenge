# MonomytoChallenge

Aplicação para o desafio da Monomyto para Desenvolvedor BackEnd.

### Cachaças Canuto 🍺

Aplicação REST, sobre uma empresa fictícia Cachaças Canuto.

Aplicação coleta valores das seguintes Urls:

* [Catalogo.json](https://firebasestorage.googleapis.com/v0/b/testemonomytobackend/o/Catalogo.json?alt=media&token=b1e62709-c1a1-4b39-94ef-596c0fb65030)
* [Clientes.json](https://firebasestorage.googleapis.com/v0/b/testemonomytobackend/o/Clientes.json?alt=media&token=2fb4fc55-5299-4dfc-9059-d2ddb4ec67ab)
* [Vendas.json](https://firebasestorage.googleapis.com/v0/b/testemonomytobackend/o/Vendas.json?alt=media&token=792a67d4-d0d0-4b9a-a099-86165322ce2a)

E realiza a criação do banco SQLite e inserção dos dados.

### Controller

A aplicação possui controllers para roteamento da API, afim de acessar informações via método GET das entidades: Produto, Cliente e Venda.

## Instalação

### Requisitos
* Docker
* Linux/WSL

### Execução
* Realizar clone do repositório.
* Abrir o terminal e executar o comando `docker-compose up` na pasta raiz.
* A aplicação está executando ✅

### Postman
Coleção do Postman para testar as rotas: [Download](https://drive.google.com/file/d/1GtEtc6Z9Bux6nz3SHN4sctxVvGD7Xrk7/view?usp=sharing)
