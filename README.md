# Pokemon
This Web API application, integrated with Auth0, is designed to securely view and insert Pokemon data. The project's goal is to learn how to implement authorization to an ASP.NET Core Web API application using standard JWT middleware. This project allows me to get to know Auth0 and understand the essential concepts of authorization in Auth0.

## Table of Contents
- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [Contact](#contact)

## Installation

1. **Clone the repository**:
    ```bash
    git clone https://github.com/AnhNotAnh/Pokemon-Auth0
    ```

2. **Install dependencies**:
    Install all necessary packages for Entity Framework, Dependency Injection, PostgreSQL (you can use another database if preferred), and JwtBearer (if those are not installed).

3. **Configure the database connection string and create tables**:
    Update the connection string in `appsettings.json`.
    Run `Update-Database` to apply the migration.

4. **Configure Auth0**:
    Create an Auth0 account, create an API, and note down your Domain (e.g., tenant.us.auth0.com) and Audience/Identifier.
    Replace your Domain and Audience with the ones in `appsettings.json` under the Auth0 section.

## Usage

1. **Start the Web API Application**:
    Run the app to launch Swagger UI, where you can test Auth0 authorization and send requests.

2. **Open your browser and test**:
    There are two ways to test:
    1. In the Application section (Auth0 website), click on APIs, choose the API you have just created, and you will see the Test section where you can find the token in the Response. 
    Insert this token when clicking "authorize" in Swagger to authorize yourself, and you can start making requests from now on.
    2. This can also be achieved using Postman: import the provided cURL in the Test section of Application APIs (Auth0) to get the response and use it to authorize and make requests to the API.

## Features

- Get Pokemon details
- Insert Pokemon
- Find Pokemon using ID

## Contact

Duy Quoc Anh Nguyen - [Outlook](mailto:QuocAnhWork@outlook.com)
