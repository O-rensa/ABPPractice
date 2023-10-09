FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Employee.Web.Host/Employee.Web.Host.csproj", "src/Employee.Web.Host/"]
COPY ["src/Employee.Web.Core/Employee.Web.Core.csproj", "src/Employee.Web.Core/"]
COPY ["src/Employee.Application/Employee.Application.csproj", "src/Employee.Application/"]
COPY ["src/Employee.Core/Employee.Core.csproj", "src/Employee.Core/"]
COPY ["src/Employee.EntityFrameworkCore/Employee.EntityFrameworkCore.csproj", "src/Employee.EntityFrameworkCore/"]
WORKDIR "/src/src/Employee.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Employee.Web.Host", "src/Employee.Web.Host"]
COPY ["src/Employee.Web.Core", "src/Employee.Web.Core"]
COPY ["src/Employee.Application", "src/Employee.Application"]
COPY ["src/Employee.Core", "src/Employee.Core"]
COPY ["src/Employee.EntityFrameworkCore", "src/Employee.EntityFrameworkCore"]
WORKDIR "/src/src/Employee.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Employee.Web.Host.dll"]
