FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY Drivers/DigiDesp.Drivers.Api/DigiDesp.Drivers.Api.csproj Drivers/DigiDesp.Drivers.Api/
COPY Drivers/DigiDesp.Drivers.Application/DigiDesp.Drivers.Application.csproj Drivers/DigiDesp.Drivers.Application/
COPY Drivers/DigiDesp.Drivers.Domain/DigiDesp.Drivers.Domain.csproj Drivers/DigiDesp.Drivers.Domain/
COPY Drivers/DigiDesp.Drivers.Infra.Data/DigiDesp.Drivers.Infra.Data.csproj Drivers/DigiDesp.Drivers.Infra.Data/
COPY Drivers/DigiDesp.Drivers.CrossCutting.IoC/DigiDesp.Drivers.CrossCutting.IoC.csproj Drivers/DigiDesp.Drivers.CrossCutting.IoC/
RUN dotnet restore "./Drivers/DigiDesp.Drivers.Api/DigiDesp.Drivers.Api.csproj"
COPY . .

WORKDIR /src/Drivers/DigiDesp.Drivers.Api/
RUN dotnet build DigiDesp.Drivers.Api.csproj -c Release -o /app

FROM build as publish
RUN dotnet publish DigiDesp.Drivers.Api.csproj -c Release -o /app

# Build runtime image
FROM base as final
WORKDIR /app
COPY --from=build-env /app .
ENTRYPOINT ["dotnet", "DigiDesp.Drivers.Api.dll"]


#FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443

#FROM microsoft/dotnet:2.2-sdk AS build
#WORKDIR /src
#COPY Usuarios/Apresentacao/Inteegra.Mice.Usuarios.Api/Inteegra.Mice.Usuarios.Api.csproj Usuarios/Apresentacao/Inteegra.Mice.Usuarios.Api/
#COPY Usuarios/Aplicacao/Inteegra.Mice.Usuarios.Aplicacao/Inteegra.Mice.Usuarios.Aplicacao.csproj Usuarios/Aplicacao/Inteegra.Mice.Usuarios.Aplicacao/
#COPY Cerne/Inteegra.Mice.Cerne.Generalizacoes/Inteegra.Mice.Cerne.Generalizacoes.csproj Cerne/Inteegra.Mice.Cerne.Generalizacoes/
#COPY Usuarios/Dominio/Inteegra.Mice.Usuarios.Dominio/Inteegra.Mice.Usuarios.Dominio.csproj Usuarios/Dominio/Inteegra.Mice.Usuarios.Dominio/
#RUN dotnet restore ./Usuarios/Apresentacao/Inteegra.Mice.Usuarios.Api/Inteegra.Mice.Usuarios.Api.csproj
#COPY . .
#WORKDIR /src/Usuarios/Apresentacao/Inteegra.Mice.Usuarios.Api
#RUN dotnet build Inteegra.Mice.Usuarios.Api.csproj -c Release -o /app

#FROM build AS publish
#RUN dotnet publish Inteegra.Mice.Usuarios.Api.csproj -c Release -o /app

#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "Inteegra.Mice.Usuarios.Api.dll"]