Meeting Management API
=========================

This API is designed to manage users, user levels, meetings, and meeting attendance through facial recognition.

Technologies Used
----------------------

* .NET Core 8
* Entity Framework Core
* Mediator
* CQRS

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

### Users

* **GET /api/usuarios**: Returns all registered users.
* **GET /api/usuarios/{id}**: Returns a specific user by ID.
* **POST /api/usuarios**: Creates a new user.
* **PUT /api/usuarios/{id}**: Updates an existing user by ID.
* **DELETE /api/usuarios/{id}**: Removes a user by ID.

### User Levels

* **GET /api/niveis**: Returns all registered user levels.
* **GET /api/niveis/{id}**: Returns a specific user level by ID.
* **POST /api/niveis**: Creates a new user level.
* **PUT /api/niveis/{id}**: Updates an existing user level by ID.
* **DELETE /api/niveis/{id}**: Removes a user level by ID.

### Meetings

* **GET /api/reunioes**: Returns all registered meetings.
* **GET /api/reunioes/{id}**: Returns a specific meeting by ID.
* **POST /api/reunioes**: Creates a new meeting.
* **PUT /api/reunioes/{id}**: Updates an existing meeting by ID.
* **DELETE /api/reunioes/{id}**: Removes a meeting by ID.

### Attendance at Meetings

* **POST /api/reunioes/{id}/presenca**: Registers presence in a meeting using facial recognition. Send the image of the user's face in the body of the request.

PT-BR
-----

API de Gestão de Reuniões
=========================

Esta API foi desenvolvida para gerenciar usuários, níveis de usuário, reuniões e presença em reuniões através de reconhecimento facial.

Tecnologias Utilizadas
----------------------

*   .NET Core 8
*   Entity Framework Core
*   Mediator
*   CQRS

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

### Usuários

*   **GET /api/usuarios**: Retorna todos os usuários cadastrados.
*   **GET /api/usuarios/{id}**: Retorna um usuário específico pelo ID.
*   **POST /api/usuarios**: Cria um novo usuário.
*   **PUT /api/usuarios/{id}**: Atualiza um usuário existente pelo ID.
*   **DELETE /api/usuarios/{id}**: Remove um usuário pelo ID.

### Níveis de Usuário

*   **GET /api/niveis**: Retorna todos os níveis de usuário cadastrados.
*   **GET /api/niveis/{id}**: Retorna um nível de usuário específico pelo ID.
*   **POST /api/niveis**: Cria um novo nível de usuário.
*   **PUT /api/niveis/{id}**: Atualiza um nível de usuário existente pelo ID.
*   **DELETE /api/niveis/{id}**: Remove um nível de usuário pelo ID.

### Reuniões

*   **GET /api/reunioes**: Retorna todas as reuniões cadastradas.
*   **GET /api/reunioes/{id}**: Retorna uma reunião específica pelo ID.
*   **POST /api/reunioes**: Cria uma nova reunião.
*   **PUT /api/reunioes/{id}**: Atualiza uma reunião existente pelo ID.
*   **DELETE /api/reunioes/{id}**: Remove uma reunião pelo ID.

### Presença em Reuniões

*   **POST /api/reunioes/{id}/presenca**: Registra a presença em uma reunião através de reconhecimento facial. Envie a imagem do rosto do usuário no corpo da requisição.
