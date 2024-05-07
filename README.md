Meeting Management API
=========================

This API is designed to manage persons, persons levels, meetings, and meeting attendance through facial recognition.

Technologies Used
----------------------

* .NET Core 8
* Entity Framework Core
* Mediator
* CQRS
* CognitiveServices Vision Face
* SQL Server

Environment Setting
------------------------

Make sure you have .NET Core 8 installed on your machine. To configure the environment, follow the steps below:

1. Clone this repository to your local machine.
2. Open the project in your preferred code editor.
3. Configure the database connection string in the `appsettings.json` file.

json

Copy code

`"ConnectionStrings": { "DefaultConnection": "your_connection_string_here" }`

4. Run the Entity Framework Core migrations to create the database:

bash

Copy code

`dotnet ef database update`

5. Launch the application:

bash

Copy code

`dotnet run`

API routes
------------

### Persons

* **GET /api/v1/persons**: Returns all registered persons.
* **GET /api/v1/persons/{id}**: Returns a specific person by ID.
* **POST /api/v1/persons**: Creates a new person.
* **PUT /api/v1/persons/{id}**: Updates an existing person by ID.
* **DELETE /api/v1/persons/{id}**: Removes a person by ID.

### Persons Levels

* **GET /api/v1/personLevels**: Returns all registered person levels.
* **GET /api/v1/personLevels/{id}**: Returns a specific person level by ID.
* **POST /api/v1/personLevels**: Creates a new person level.
* **PUT /api/v1/personLevels/{id}**: Updates an existing person level by ID.
* **DELETE /api/v1/personLevels/{id}**: Removes a person level by ID.

### Meetings

* **GET /api/v1/meetings**: Returns all registered meetings.
* **GET /api/v1/meetings/{id}**: Returns a specific meeting by ID.
* **POST /api/v1/meetings**: Creates a new meeting.
* **PUT /api/v1/meetings/{id}**: Updates an existing meeting by ID.
* **DELETE /api/v1/meetings/{id}**: Removes a meeting by ID.

### Attendance at Meetings

* **POST /api/v1/meetings/{id}/attendance**: Registers presence in a meeting using facial recognition. Send the image of the person's face in the body of the request.

PT-BR
-----

API de Gestão de Reuniões
=========================

Esta API foi desenvolvida para gerenciar usuários, níveis de usuário, reuniões e presença em reuniões através de reconhecimento facial.

Tecnologias Utilizadas
----------------------

* .NET Core 8
* Entity Framework Core
* Mediator
* CQRS
* CognitiveServices Vision Face
* SQL Server

Configuração do Ambiente
------------------------

Certifique-se de ter o .NET Core 8 instalado em sua máquina. Para configurar o ambiente, siga os passos abaixo:

1.  Clone este repositório em sua máquina local.
2.  Abra o projeto em seu editor de código preferido.
3.  Configure a string de conexão com o banco de dados no arquivo `appsettings.json`.

json

Copy code

`"ConnectionStrings": {     "DefaultConnection": "sua_string_de_conexao_aqui" }`

4.  Execute as migrações do Entity Framework Core para criar o banco de dados:

bash

Copy code

`dotnet ef database update`

5.  Inicie a aplicação:

bash

Copy code

`dotnet run`

Rotas da API
------------

### Pessoas

*   **GET /api/v1/persons**: Retorna todos os pessoas cadastradas.
*   **GET /api/v1/persons/{id}**: Retorna uma pessoa específica pelo ID.
*   **POST /api/v1/persons**: Cria uma nova pessoa.
*   **PUT /api/v1/persons/{id}**: Atualiza uma pessoa existente pelo ID.
*   **DELETE /api/v1/persons/{id}**: Remove uma pessoa pelo ID.

### Níveis de Usuário

*   **GET /api/v1/personLevels**: Retorna todos os níveis de pessoas cadastrados.
*   **GET /api/v1/personLevels/{id}**: Retorna um nível de pessoa específico pelo ID.
*   **POST /api/v1/personLevels**: Cria um novo nível de pessoa.
*   **PUT /api/v1/personLevels/{id}**: Atualiza um nível de pessoa existente pelo ID.
*   **DELETE /api/v1/personLevels/{id}**: Remove um nível de pessoa pelo ID.

### Reuniões

*   **GET /api/v1/meetings**: Retorna todas as reuniões cadastradas.
*   **GET /api/v1/meetings/{id}**: Retorna uma reunião específica pelo ID.
*   **POST /api/v1/meetings**: Cria uma nova reunião.
*   **PUT /api/v1/meetings/{id}**: Atualiza uma reunião existente pelo ID.
*   **DELETE /api/v1/meetings/{id}**: Remove uma reunião pelo ID.

### Presença em Reuniões

*   **POST /api/v1/meetings/{id}/attendance**: Registra a presença em uma reunião através de reconhecimento facial. Envie a imagem do rosto do usuário no corpo da requisição.
