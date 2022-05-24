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
11. Add two nupkg files to "LocalNugetRepository"

12. cd Package1
13. dotnet build
14. Add nuget configs and add shared package to csproj
15. create package with nuget pack
16. add packages to local folder

17. Follow previous step for package 2.

18. install two packages in webapi
19. Run package methods which use shared package method

20. https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/versioning

"The assembly version is what the CLR uses at run time to select which version of an assembly to load."
"Selecting an assembly using versioning only applies to assemblies with a strong name."