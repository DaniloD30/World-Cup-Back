# Movie World Cup

- [Introdução](#st1)
- [A Aplicação](#st2)
- [Executando a Aplicação](#st3)
 - [Iniciando a Aplicação](#st4)
- [Link da Aplicação](#st5)
- [Teste com o xUnit](#st6)

<div id='st1' />

## Introdução

ASP.NET Core Web API para realização da copa do mundo de filmes.

<div id='st2' />

## A Aplicação

A aplicação foi desenvolvida em C#, utilizando :
- [ASP.NET](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-5.0)
- [Heroku](https://www.heroku.com/what) (deploy contínuo)
- [xUnit](https://xunit.net/)
- [Arquitetura](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller) 

<div id='st3' />

## Executando a Aplicação

```sh
  git clone https://github.com/DaniloD30/World-Cup-Back
```
```sh
  cd World-Cup-Back
```
```sh
   dotnet restore
```
```sh
   cd ChallengerBack
```
```sh
   dotnet run
```
<div id='st4' />
Ao final, acesse

```sh
  https://localhost:5001/swagger/index.html
``` 

<div id='st5' />

# Link da Aplicação

A Aplicação está disponível no Heroku atráves deste [Link](https://worldcupmovie.herokuapp.com/swagger/index.html).

<div id='st6' />

# Execução do teste
Execute
```sh
  dotnet test
```
