FROM microsoft/dotnet:2.1-sdk AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY *.sln ./
COPY Service.A/Service.A.csproj Service.A/
COPY Service.A.Service/Service.A.Service.csproj Service.A.Service/
COPY . .
WORKDIR /src/Service.A
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Service.A.dll"]
