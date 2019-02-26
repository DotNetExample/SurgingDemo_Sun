FROM microsoft/dotnet:2.1-sdk AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY *.sln ./
COPY Service.C/Service.C.csproj Service.C/
COPY Service.C.Service/Service.C.Service.csproj Service.C.Service/
COPY . .
WORKDIR /src/Service.C
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Service.C.dll"]
