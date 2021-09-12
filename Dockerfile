#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["UPS.Api/UPS.Api.csproj", "UPS.Api/"]
COPY ["UPS.BusinessServices/UPS.BusinessServices.csproj", "UPS.BusinessServices/"]
COPY ["UPS.Framework/UPS.Framework.csproj", "UPS.Framework/"]
COPY ["UPS.Abstract/UPS.Abstract.csproj", "UPS.Abstract/"]
COPY ["UPS.BusinessModels/UPS.BusinessModels.csproj", "UPS.BusinessModels/"]
COPY ["UPS.Enums/UPS.Enums.csproj", "UPS.Enums/"]
COPY ["UPS.DB/UPS.DB.csproj", "UPS.DB/"]
RUN dotnet restore "UPS.Api/UPS.Api.csproj"
COPY . .
WORKDIR "/src/UPS.Api"
RUN dotnet build "UPS.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UPS.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UPS.Api.dll"]