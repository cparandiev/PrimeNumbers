# Prime Numbers API

Prime Numbers API is a server application, which provides REST API for two functionality:

- Determines if the given number is a prime number
- Returns the next prime number which is greater or equal to the given number   

## Getting started
### Prerequisites

You will need the following tools:
    
- .NET Core SDK 3.1
    
or
- Docker

### Setup with .NET Core SDK

1. Clone the repository

2. At the root directory, restore required packages by running:

```
dotnet restore
```

3. Next, build the solution by running:
```
dotnet build
```

4. Next, within the `PrimeNumbers.API` directory, launch the server by running:
```
dotnet run
```

5. Launch http://localhost:5000 in your browser to view the Swagger UI

### Setup with Docker

1. Clone the repository

2. At the root directory, launch the container by:

```
docker-compose build
docker-compose up
```

3. Launch http://localhost:80 in your browser to view the Swagger UI

## Used Technologies
* .NET Core 3
* ASP.NET Core 3

