FROM microsoft/dotnet:2.1-sdk AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY *.sln ./
COPY Service.B/Service.B.csproj Service.B/
COPY Service.B.Service/Service.B.Service.csproj Service.B.Service/
COPY . .
WORKDIR /src/Service.B
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Service.B.dll"]
