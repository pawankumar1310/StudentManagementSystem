# StudentManagementSystem
This is the first dotnet project in which we are going to use .Net MVC, ADO.NET, Entity Framework, Database First Approach and Code First Apprach, Stored Procedure etc. It is API based application which will connect to blazor application(StudentManagement).

### About Projects :
This project is a simple management system for students. It includes basic functionalities such as adding, deleting, updating and fetching data.

Dear Team,

I am thrilled to introduce an engaging project that will allow us to showcase our expertise in .Net 7 and SQL Server 2022 technologies. Our mission is to develop robust REST APIs for manipulating data from a CSV file and performing various database operations. This project is a great learning opportunity.


### Key Technologies:
- .Net 7
- SQL Server 2022
- Code Editor: VS Code

### Project Overview:
We aim to create three primary REST APIs for inserting, deleting, and updating data in the database. Additionally, we will explore creating some auxiliary modules to enhance the functionality and user experience of our application.

Here are the core tasks and requirements for each API:
#### Backend : 

1. Create API:
   - Accept and validate a request containing data for insertion, ensuring it adheres to the required format and constraints.
   - Insert the validated data into the appropriate table in the database.

2. Delete API:
   - Accept a request with a unique identifier (e.g., Student_ID) for the data to be deleted.
   - Verify the existence of the data in the database before deletion.
   - Delete the corresponding data from the appropriate table in the database.

3. Update API:
   - Accept a request with updated data and a unique identifier.
   - Verify the existence of the data in the database.
   - Update the corresponding data in the appropriate table with the provided changes.

**Additional Tasks** :

4. Data Validation Module:
   - Develop a module to perform advanced data validation checks.
   - Implement custom validation rules and error messages.

5. Logging and Error Handling:
   - Implement comprehensive logging for tracking API requests and responses.
   - Develop a standardized error handling mechanism to manage exceptions gracefully.

6. API Documentation:
   - Create detailed API documentation using tools like Swagger.
   - Include examples and status codes for each endpoint.

7. Unit Testing:
   - Write unit tests for each API endpoint ensuring code coverage of at least 80%.
   - Use mocking frameworks to simulate database operations.

8. Database Seeding Script:
   - Create a script to populate the database initially using the attached CSV file.
   - Ensure the script can be run multiple times without duplicating data.

The CSV file containing the initial data is attached to this email for your reference. Please use this file to populate the database initially and test the functionality of the APIs.

#### Front-End

#### Task Overview:  
1. Frontend Development: Create a frontend interface using pure HTML, CSS, and JavaScript for the API layer you have created.
2. Integration: Seamlessly integrate the newly developed frontend with previously developed .NET API layer.
3. Incorporate Feedback: Address and incorporate the comments and feedback provided during our review of the API layer.


### Additional Features 

#### Tasks for the Final Phase:

1. Transition to Blazor Client: Replace the existing UI components built with HTML, CSS, and JavaScript, and adopt Blazor Client for UI development.

2. UI Revamp: Reuse the existing HTML and CSS. Feel free to modify and enhance the user interface as you see fit.

3. Database Connection: Transition from the Entity Framework to ADO.NET for SQL server connections.

4. Backend Structure: Combine multiple projects in the backend into a single cohesive project for better manageability.

5. Validation: Implement Regex-based validation in both frontend and backend modules.

6. Soft Delete Feature: Integrate soft delete capabilities into the existing modules.

7. User Feedback: Refrain from using default browser alert messages. Instead, incorporate custom modals or pages for displaying alerts or statuses in a more modernized fashion.

8. Coding Standards: Adhere to the coding standards provided in the attached reference links.

9. Avoid Hardcoding: Ensure no hardcoded values are present. If any exist, they should be promptly removed.

10. CSV Data Ingestion: Develop a feature to read CSV files from the frontend, and transmit this data to the backend for database population.

11. Data Export: Implement functionality to extract and download data from the database into an Excel sheet format.

12. Database Truncation: Add a feature that enables truncating the database.

13. Logging and Validation: Ensure comprehensive logging and robust validation mechanisms are in place for both frontend and backend.

### Blazor

14. Blazor UI: Develop an interactive user interface using Blazor technology. This will serve as the primary means of interacting with the user.

Attachments :

- C# identifier names - rules and conventions - https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names

- .NET documentation C# Coding Conventions - https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions



#### 1. Prerequisites:
1. Create webapi => dotnet new webapi
2. install C#
3. install Nuget Package Manager
4. Install entity framework (Database first approach) => dotnet tool install --global dotnet-ef
5. Add package write command => dotnet add package Microsoft.EntityFrameworkCore.Design
	OR 
	ctrl + shift + p -> Choose Nuget add package -> Microsoft.EntityFrameworkCore.SqlServer
 
6. Execute the below command for verify the EF installation => dotnet ef
7. Open sql server create database (StudentDbDemo) and go to Tasks -> Import Flat file (.csv) and run below command in vs code terminal.
8. Enter scaffold command 

	dotnet ef dbcontext scaffold "Server = DESKTOP-RUJ2TUO;
				      Database=TestDemo;
				      Trusted_Connection=True;
				      TrustServerCertificate=True;"
 	Microsoft.EntityFrameworkCore.SqlServer --output-dir Models


	OR 

	dotnet ef dbcontext scaffold "Server=DESKTOP-G0N0BUD\\SQLEXPRESS;Database=StudentDbDemo;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f


9. appsettings.json

 "ConnectionStrings": {
    "ConnectionStrings" : "Server = DESKTOP-RUJ2TUO;
			   Database=TestDemo;
			   Trusted_Connection=True;
			   TrustServerCertificate=True;"
  }

10. Program.cs 

 builder.Services.AddDbContext<TestDemoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings"));
});

11. Run application : dotnet run
12. Paste url : http://localhost:5008/swagger
14. Create controllers to create api.

13. Creating a new blazor application : dotnet new blazorwasm -n YourAppName



#### Branch Descriptions :
1. First main branch is responsible for only  creating an new web API using Entity Framework Core(Database First Approach) and SQL Server database with CRUD operations.In this, i have imported (csv file) and made only Student_Id as primary key.

2. Second DbFirstApproach branch : In it i have  created the database first approach using Entity Framework Core' the database name is 'StudentDB' which has validation. Based on this validation. I have created validation on model class.
- Run the following command :
 
 ` dotnet ef dbcontext scaffold "Server=DESKTOP-G0N0BUD\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f ` 
 


