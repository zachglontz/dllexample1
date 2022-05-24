1. dotnet new webapi --name DllExample1WebApi
2. dotnet new classlib --name Package1
3. dotnet new classlib --name Package2
4. dotnet new classlib --name SharedPackage


5. cd Sharedpackage
6. dotnet build
7. csproj set version 1 & set console log to 1
8. dotnet pack
9. csproj set version 2 & set console log to 2
10. dotnet pack
