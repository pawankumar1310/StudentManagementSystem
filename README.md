# StudentManagementSystem
This is the first dotnet project in which we are going to use .Net MVC, ADO.NET, Entity Framework, Database First Approach and Code First Apprach, Stored Procedure etc. It is API based application which will connect to blazor application(StudentManagement).



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
1. First main branch is responsible for only  creating an new web API using Entity Framework Core and SQL Server database with CRUD operations.