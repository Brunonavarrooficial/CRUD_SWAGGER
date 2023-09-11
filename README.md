

# Projeto de CRUD de Livros com Swagger

Este é um projeto de CRUD (Create, Read, Update, Delete) de livros em C# que utiliza o ASP.NET Core 6, Entity Framework Core, SQLite e Swagger para documentação da API.

## Requisitos de Instalação

- [ASP.NET Core 6](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/) (opcional)
- [SQLite](https://www.sqlite.org/index.html)
- [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore/6.5.0)

![Descrição da imagem](https://3025166959-files.gitbook.io/~/files/v0/b/gitbook-legacy-files/o/assets%2F-MgwMOcm4UygF4VcCNIq%2F-Mj_A8lxzMa4XaT3D1mT%2F-Mj_AvIoKnZa-1neamkq%2Fswagger.png?alt=media&token=b883b913-6afc-4de3-9ec4-c5a09d8081c8)


## Configuração

1. Clone este repositório para a sua máquina local:

```bash
git clone git@github.com:Brunonavarrooficial/CRUD_SWAGGER.git
```

2. Navegue até o diretório do projeto:

```bash
cd seu-projeto
```

3. Abra o projeto com seu ambiente de desenvolvimento preferido (Visual Studio ou Visual Studio Code).

4. Certifique-se de ter o ASP.NET Core 6 instalado e definido como o ambiente de execução.

## Executando o Projeto

1. Abra o arquivo `Program.cs` e verifique a configuração do banco de dados SQLite. Por padrão, ele está configurado para usar um arquivo chamado `book.db`.

2. Compile o projeto:

```bash
dotnet build
```

3. Execute o projeto:

```bash
dotnet run
```

O projeto estará disponível em [http://localhost:5000](http://localhost:5000). Você pode acessar a documentação da API Swagger em [http://localhost:5000/swagger](http://localhost:5000/swagger).

## Uso da API Swagger

A API Swagger é uma ferramenta de documentação interativa que permite explorar e testar endpoints da API diretamente pelo navegador. Acesse [http://localhost:5000/swagger](http://localhost:5000/swagger) para começar a usá-la.

## Modelos de Dados

### Book

- `Id` (int): Identificador único do livro.
- `Author` (string): Autor do livro.
- `Description` (string): Descrição do livro.
- `Title` (string): Título do livro.

## Endpoints da API

A API possui os seguintes endpoints:

- `GET /api/books`: Retorna a lista de todos os livros.
- `GET /api/books/{id}`: Retorna os detalhes de um livro específico.
- `POST /api/books`: Cria um novo livro.
- `PUT /api/books/{id}`: Atualiza os detalhes de um livro existente.
- `DELETE /api/books/{id}`: Deleta um livro existente.

## Contribuição

Se desejar contribuir para este projeto, siga estas etapas:

1. Faça um fork do repositório.
2. Crie uma branch com a sua feature: `git checkout -b minha-feature`
3. Faça commit das suas mudanças: `git commit -m 'Adicionei uma nova feature'`
4. Envie as mudanças para o seu fork: `git push origin minha-feature`
5. Abra um pull request no repositório original.

## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.
```