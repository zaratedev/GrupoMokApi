# Grupo Mok Api Book

## Requisitos

- SDK .NET 8.0
- Visual Studio Code

## Instalación

1. Clone este repositorio

```

```

2. Ingrese a la carpeta del proyecto

`cd GrupoMokApi`

3. Instale las dependencias del proyecto
Ejecuta el siguiente comando para restaurar las dependencias del proyecto:

```
dotnet restore
```

4. Ejecutar la api

```
dotnet run
```

La salida muestra mensajes similares al siguiente, que indican que la aplicación se está ejecutando y esperando solicitudes

```
...
info: Microsoft.Hosting.Lifetime[14]
    Now listening on: http://localhost:{port}
...

```

## API Book

### Documentación
Se usa Swagger para generar la documentación de la API de book. Visite http://localhost:{port}/swagger

### Endpoints

**POST** `/api/auth/login`

Use este endpoint para obtener el token para usarlo en el CRUD de la API Book

Ejemplo
```
curl --location 'http://localhost:{port}/api/auth/login' \
--header 'Content-Type: application/json' \
--data '{
    "username": "grupomok",
    "password": "password"
}'
```

Respuesta
```
{
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

**GET** `/api/Books`

Lista de books

Ejemplo
```
curl --location 'http://localhost:{port}/api/Books' \
--header 'Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...'
```

Respuesta
```json
[
    {
        "id": 1,
        "title": "100 años de soledad",
        "author": "Joe Doe",
        "genre": "Romantic",
        "publishDate": "2020-03-05T18:45:53.792Z"
    }
]
```

**POST** `/api/Books`

Crear un Book

```
curl --location 'http://localhost:{port}/api/Books' \
--header 'Content-Type: application/json' \
--header 'Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...' \
--data '{
  "title": "100 años de soledad",
  "author": "Joe Due",
  "genre": "Action",
  "publishDate": "2020-03-05T18:45:53.792Z"
}'
```

Respuesta

```json
{
    "id": 1,
    "title": "100 años de soledad",
    "author": "Joe Doe",
    "genre": "Romantic",
    "publishDate": "2020-03-05T18:45:53.792Z"
}
```

**GET** `/api/Books/{id}`

Obtener un Book

```
curl --location 'http://localhost:{port}/api/Books/1' \
--header 'Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...'
```

Respuesta

```json
{
    "id": 1,
    "title": "100 años de soledad",
    "author": "Joe Doe",
    "genre": "Romantic",
    "publishDate": "2020-03-05T18:45:53.792Z"
}
```

**PUT** `/api/Books/{id}`

Actualizar un Book

```
curl --location --request PUT 'http://localhost:{port}/api/Books/1' \
--header 'Content-Type: application/json' \
--header 'Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...' \
--data '{
    "id": 1,
    "title": "Juego de tronos",
    "author": "Joe Due",
    "genre": "Action",
    "publishDate": "2000-03-05T18:45:53.792Z"
}'
```

Respuesta

`204 No Content`

**DELETE** `/api/Books/{id}`

Eliminar un Book

```
curl --location --request PUT 'http://localhost:{port}/api/Books/1' \
--header 'Content-Type: application/json' \
--header 'Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...'
```
Respuesta

`204 No Content`