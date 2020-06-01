FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /app/publish 

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS final
COPY --from=build /app/publish /app
ENTRYPOINT ["dotnet", "/app/OldGitHubPackagesCleaner.dll"]