# Animal Shelter API

#### By Jackson Levine

#### This is a project to build a basic API for an imaginary Animal Shelter.

## Technologies Used

* .Net 6 SDK

* C#

* EFCore

* ASP.Net MVC

* No views, only controllers!

## Goals/Objectives

This project shows how to use Asp.Net MVC/EF Core for an API.

## Description

This project uses models along with routes defined in the controller to return json in response to multiple endpoints!

# Endpoints

This API has the following endpoints, assuming the website is hosted on localhost:5000

If not otherwise specified, all endpoints are available in the default version, 1.0

------------------------------------------------------------------------------------------

* GET all animals

`localhost:5000/api/animals`

Parameters (all optional):

* species (string)
* name (string)
* minimumAge (int)

------------------------------------------------------------------------------------------

* GET one animal by ID (This feature is only available in deprecated version 1.2 of this api.)

In order to use this request, make sure to add the header "x-api-version" to your request, with the value "1.2"

(replace {id} with animal id)

`localhost:5000/api/animals/{id}`

------------------------------------------------------------------------------------------

* POST to create new animal in database:

`localhost/api/animals`

Include object literal in request body: for example:

`{
    "species": "Woolly Mammoth",
    "name": "Matilda the Woolly Mammoth",
    "age": 8
}`

NOTE: Do not include animalId, as this is assigned by the database.

------------------------------------------------------------------------------------------

* PUT to update an existing animal

`localhost:5000/api/animals/{id}`

Include object literal, including animalId, in request body: for example:

`{
    "animalId": 1
    "species": "Woolly Mammoth",
    "name": "Matilda the Woolly Mammoth",
    "age": 8
}`

------------------------------------------------------------------------------------------

## How To Run This Project

If you have not already, install the `dotnet-ef` tool by running the following command in your terminal:

```
dotnet tool install --global dotnet-ef --version 6.0.0
```

### Set Up and Run Project

1. Clone this repo.

2. Open the terminal and navigate to this project's production directory called "AnimalShelterApi".

3. Within the production directory "AnimalShelterApi", create a new file called `appsettings.json`.

4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=root;pwd=epicodus;"
  }
}
```

5. Create the database using the migrations in the To Do List project. Open your shell (e.g., Terminal or GitBash) to the production directory "AnimalShelterApi", and run `dotnet ef database update`. 
    - To optionally create a migration, run the command `dotnet ef migrations add MigrationName` where `MigrationName` is your custom name for the migration in UpperCamelCase. To learn more about migrations, visit the LHTP lesson [Code First Development and Migrations](https://www.learnhowtoprogram.com/c-and-net-part-time/many-to-many-relationships/code-first-development-and-migrations).

6. Use the endpoints specified earlier in this README to access the create, read, update, and delete functionality of this API. This can be done in Postman, or through a web application.

7. (Optional) Within the production directory "AnimalShelterApi", run `dotnet watch run` in the command line to start the project in development mode with a watcher.

## Database Instructions 

* In your terminal type to create a db migration: $ dotnet ef migrations add Initial

* Updating the Database with the Migration: $ dotnet ef database update

## DB (Optional)

* If you would like to see a current view of the database: Open SQL workbench.

* Navigate to the "Administration" tab in SQL Workbench.

* Click "Schema" 

* Right hand mouse click "Refresh All".

* The _Name the schema "project_name" of the database in this current project will be in view

## Known Bugs

* None

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) 2023 Jackson Levine
