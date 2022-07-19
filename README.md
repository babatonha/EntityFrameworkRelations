# EntityFrameworkRelations


# Steps
--Datacontext.
--Add connection string
--Add sql server on the startup/program file.
--Create model
--Add model dbSet on the DataContext


# Packages
Microsoft entiFrameworkCore
EntityFrameworkCore.SqlServer
Entity FrameworkCore Design
https://www.nuget.org/packages/dotnet-ef/

# Entity Framework Commands
dotnet ef migrations add UserEnity
dotnet ef database update


# Relationships

# One To One
user can only have one address
# One To Many.
user can create many jobs
# Many To Many.
user can have many roles and a role can belong to many users
