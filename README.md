# ToDoList API

## Descrição
Esta é uma API desenvolvida em .NET para gerenciamento de listas de tarefas. A aplicação segue os princípios da Clean Architecture e inclui funcionalidades de criação, edição e recuperação de tarefas.

## Estrutura do Projeto
A solução está organizada da seguinte forma:

- **Application**: Contém os casos de uso.
- **Controllers**: Implementação dos endpoints da API.
- **Domain**: Contém a definição do contexto da aplicação.
- **Dto**: Define objetos de transferência de dados.
- **Entities**: Modelos de entidades da aplicação.
- **Migrations**: Arquivos de migração do Entity Framework.
- **Repositories**: Implementação de repositórios para acesso ao banco de dados.

## Requisitos
Antes de iniciar, certifique-se de ter instalado:

- .NET 8
- SQL Server ou SQLite (dependendo da configuração do banco de dados)
- Visual Studio ou VS Code

## Configuração e Execução
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/ToDoList.git
   ```
2. Acesse o diretório do projeto:
   ```bash
   cd ToDoList
   ```
3. Configure a string de conexão no `appsettings.json`.
4. Aplique as migrações:
   ```bash
   dotnet ef database update
   ```
5. Execute a aplicação:
   ```bash
   dotnet run
   ```

## Endpoints
A API expõe os seguintes endpoints:

- `POST /todolist/adicionar-tarefas` - Criar uma nova tarefa
- `GET /todolist/listar-tarefas` - Obter todas as tarefas
- `PUT /todolist/editar-tarefa/{id}` - Editar uma tarefa
- `DELETE /todolist/deletar-tarefa/{id}` - Excluir uma tarefa

## Testes
Para testar a API, você pode utilizar o arquivo `Web.http` no Visual Studio Code ou ferramentas como Postman e Swagger.

## Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para abrir um PR ou relatar issues.

## Licença
Este projeto está licenciado sob a MIT License - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

