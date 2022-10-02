# MonomytoChallenge

Aplicação para o desafio da Monomyto.

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
* Docker Windows em Linux/WSL
* .NET SDK

### Execução
* Realizar a instalação do SDK do .NET para geração de certificados: [Download](https://download.visualstudio.microsoft.com/download/pr/cebf08ce-ecf1-4439-8a0a-d81b3a4cad12/674ba293b83bdc9b1e00ddfa3ab82f10/dotnet-sdk-6.0.401-win-x64.exe)
* Abrir o terminal e executar o seguinte comando para limpar os certificados SSL de desenvolvimento: `dotnet dev-certs https --clean`
* Executar o seguinte comando para geração de SSL: `dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\aspnetapp.pfx -p password`
* Executar o comando `dotnet dev-certs https --trust` para aprovar o certificado
* Realizar o clone do repositório e executar o comando `docker-compose up` na pasta raiz
* A aplicação está executando ✅
* Coleção do Postman para testar as rotas: [Download](https://drive.google.com/file/d/1GtEtc6Z9Bux6nz3SHN4sctxVvGD7Xrk7/view?usp=sharing)

## Rotas

### Cliente

Obter Clientes - parâmetros: searchNome, minDate, maxDate<br/>
<b>GET</b> `/api/Cliente`<br/>
<br/>

Obter Cliente por ID <br/>
<b>GET</b> `/api/Cliente/{id}`<br/>
<br/>

Obter Relatório de Cliente - parâmetros: qtItens, minDate, maxDate<br/>
<b>GET</b> `/api/Cliente/Report`<br/>
<br/>

### Produto

Obter Produtos - parâmetros: searchNome, minTeor, maxTeor<br/>
<b>GET</b> `/api/Produto`<br/>
<br/>

Obter Produto por ID<br/>
<b>GET</b> `/api/Produto/{id}`<br/>
<br/>

Obter Relatório de Produto - parâmetros: sortValor, sortQuantidade<br/>
<b>GET</b> `/api/Produto/Report`<br/>
<br/>

### Venda

Obter Vendas - parâmetros: pageNumber, maxResults, minDate, maxDate, searchCliente, searchProduto<br/>
<b>GET</b> `/api/Venda`<br/>
<br/>




