# CarRentalSystem

🚗 **CarRentalSystem** é um sistema de locação de carros desenvolvido com **ASP.NET Core 8**, seguindo os princípios da **Arquitetura Limpa**. 

## 🔥 **Principais Funcionalidades**
- 📌 **Autenticação e Autorização** via **JWT**
- 🚙 Cadastro e gerenciamento de veículos
- 📅 Processo de **reserva e devolução** de carros
- 💳 Simulação de **pagamento** e controle de locações
- 🛠 Microsserviços comunicando-se via **RabbitMQ**
- 📄 Documentação de API com **Swagger**
- ✅ **Testes unitários** com xUnit

## 🚀 **Tecnologias Utilizadas**
✅ **ASP.NET Core 8**
✅ **Entity Framework Core (PostgreSQL)**
✅ **Arquitetura Limpa (Clean Architecture)**
✅ **CQRS (Command Query Responsibility Segregation)**
✅ **Autenticação JWT**
✅ **RabbitMQ (Mensageria para microsserviços)**
✅ **Docker e Docker Compose**
✅ **Swagger para documentação da API**
✅ **xUnit para testes unitários**

## 📂 **Estrutura do Projeto**
```
CarRentalSystem/
│── CarRental.Presentation/     # API principal (Web API)
│── CarRental.Application/      # Regras de negócio (CQRS, Services)
│── CarRental.Domain/           # Entidades e Interfaces
│── CarRental.Infrastructure/   # Acesso a dados (EF Core, PostgreSQL)
│── tests/                      # Testes unitários e de integração
│── docker-compose.yml          # Configuração de banco e RabbitMQ no Docker
│── README.md                   # Explicação do projeto e como rodar
│── .gitignore                   # Arquivos que não devem ser versionados
│── CarRentalSystem.sln          # Arquivo da solução do .NET
```

## 🛠 **Como Rodar o Projeto**
### ✅ **1. Pré-requisitos**
Certifique-se de ter instalado:
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Docker e Docker Compose](https://www.docker.com/products/docker-desktop)
- [PostgreSQL](https://www.postgresql.org/download/)

### ✅ **2. Clonar o Repositório**
```sh
git clone https://github.com/seu-usuario/CarRentalSystem.git
cd CarRentalSystem
```

### ✅ **3. Configurar o Banco de Dados e RabbitMQ**
O projeto usa **PostgreSQL** como banco de dados e **RabbitMQ** para mensageria.
Execute o comando abaixo para rodá-los via Docker:
```sh
docker-compose up -d
```
Isso iniciará:
- PostgreSQL (porta **5432**)
- RabbitMQ (porta **5672** / painel de controle em `http://localhost:15672`)

### ✅ **4. Configurar Variáveis de Ambiente**
Crie um arquivo `.env` na raiz do projeto com:
```env
POSTGRES_CONNECTION_STRING=Host=localhost;Port=5432;Database=CarRentalDb;Username=postgres;Password=postgres;
RABBITMQ_HOST=localhost
JWT_SECRET=supersecreto
```

### ✅ **5. Rodar a Aplicação**
Execute os seguintes comandos para iniciar o projeto:
```sh
dotnet restore
dotnet build
dotnet run --project CarRental.Presentation
```
A API estará disponível em:
📍 `http://localhost:5000`
📍 `http://localhost:5000/swagger` (Documentação Swagger)

### ✅ **6. Executar Testes Unitários**
```sh
dotnet test
```

## 📝 **Endpoints Principais**
### 🔑 **Autenticação**
- `POST /api/auth/register` - Criar usuário
- `POST /api/auth/login` - Autenticar usuário (JWT)

### 🚙 **Gerenciamento de Veículos**
- `POST /api/cars` - Cadastrar veículo
- `GET /api/cars` - Listar veículos disponíveis
- `PUT /api/cars/{id}` - Atualizar veículo
- `DELETE /api/cars/{id}` - Remover veículo

### 📅 **Reservas de Carros**
- `POST /api/bookings` - Criar reserva
- `GET /api/bookings` - Listar reservas
- `PUT /api/bookings/{id}/return` - Finalizar locação

## 🤝 **Contribuições**
Sinta-se à vontade para abrir uma issue ou enviar um pull request! 😉

## 📄 **Licença**
Este projeto está licenciado sob a **MIT License**.

