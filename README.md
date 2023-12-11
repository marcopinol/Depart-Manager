# Depart-Manager

Aplicativo Web com objetivo de adicionar, listar, excluir e editar departamentos e seus respectivos funcionários.
Construído com __ASP.NET Core 6__, __Angular v15.0.5__, __Node.js v18.17.1__ e __EntityFrameworkCore (versão do pacote 6.0.25)__ e __SQL Server__.

## Instalação

* Recomendavel usar as mesmas versões citadas anteriormente para evitar erros causados por incompatibilidade de versões (exceto Node que tem retrocompatibilidade) 

* Será necessário configurar a string de login no arquivo DataContext.cs para poder integrar a API ao banco de dados

## Como rodar

* Abra um cmd no diretorio da WebApi e execute o comando __dotnet run__, ali mostrará onde será hospedada localmente a Api do projeto

* Para rodar a aplicação Angular será necessário instalar os binários do Node dentro do diretório da aplicação Angular antes com o comando __npm install__, logo após a instalação dos binários do Node, poderá ser executado o comando __ng serve__ que compilará a aplicação e hospedará ela localmente

### Nota

Pode haver a possibilidade do endereço de host da Api ser diferente do que está no código da aplicação Angular, caso que tenha que mudar a URL da Api dentro do código angular, nos __arquivos de service__, mude a porta para a que está hospedada em seu computador __private urlApi = 'http://localhost:suaPorta'__
