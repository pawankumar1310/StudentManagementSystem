# StudentManagementSystem
This is the first dotnet project in which we are going to use .Net MVC, ADO.NET, Entity Framework, Database First Approach and Code First Apprach, Stored Procedure etc. It is API based application which will connect to blazor application(StudentManagement).



#### 1. Prequisite:
1. Create webapi => dotnet new webapi
2. install C#
3. install Nuget Package Manager
4. Install entity framework (Database first approach) => dotnet tool install --global dotnet-ef
5. Add package write command => dotnet add package Microsoft.EntityFrameworkCore.Design
	OR 
	ctrl + shift + p -> Choose Nuget add package -> Microsoft.EntityFrameworkCore.SqlServer
 
6. Execute the below command for verify the EF installation => dotnet ef
7. Enter scaffold command 

	dotnet ef dbcontext scaffold "Server = DESKTOP-RUJ2TUO;
				      Database=TestDemo;
				      Trusted_Connection=True;
				      TrustServerCertificate=True;"
 	Microsoft.EntityFrameworkCore.SqlServer --output-dir Models


	OR 

	dotnet ef dbcontext scaffold "Server=DESKTOP-G0N0BUD\\SQLEXPRESS;Database=StudentDbDemo;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f


8. appsettings.json

 "ConnectionStrings": {
    "ConnectionStrings" : "Server = DESKTOP-RUJ2TUO;
			   Database=TestDemo;
			   Trusted_Connection=True;
			   TrustServerCertificate=True;"
  }

9. Program.cs 

 builder.Services.AddDbContext<TestDemoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings"));
});

10. Run application : dotnet run
11. Paste url : http://localhost:5008/swagger


12. Creating a new blazor application : dotnet new blazorwasm -n YourAppName