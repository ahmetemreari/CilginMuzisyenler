# Crazy Musicians API

Welcome to the Crazy Musicians API! This API allows you to manage a list of musicians, with functionality for creating, reading, updating, and deleting musicians.

## Endpoints

### 1. **GET /api/musicians**
Retrieves all musicians.

### 2. **GET /api/musicians/{id}**
Retrieves a musician by their `id`.

### 3. **POST /api/musicians**
Creates a new musician.

### 4. **PATCH /api/musicians/{id}**
Updates a musician's fun fact.

### 5. **PUT /api/musicians/{id}**
Updates all the information of a musician.

### 6. **DELETE /api/musicians/{id}**
Deletes a musician by their `id`.

## Installation

1. Clone the repository:  
   `git clone https://github.com/ahmetemreari/crazy-musicians-api.git`
   
2. Navigate to the project directory:  
   `cd crazy-musicians-api`

3. Restore the dependencies:  
   `dotnet restore`

4. Run the project:  
   `dotnet run`

## Testing with Postman

You can use Postman to test the API endpoints by sending appropriate HTTP requests:

- **GET /api/musicians**: Retrieves all musicians.
- **GET /api/musicians/{id}**: Retrieves a musician by ID.
- **POST /api/musicians**: Creates a new musician. Include the musician data in the body.
- **PATCH /api/musicians/{id}**: Updates a musician's fun fact.
- **PUT /api/musicians/{id}**: Updates all data of a musician.
- **DELETE /api/musicians/{id}**: Deletes a musician by ID.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.