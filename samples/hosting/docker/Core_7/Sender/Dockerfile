FROM mcr.microsoft.com/dotnet/core/runtime:2.1 AS base

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /src
COPY . .
WORKDIR /src/Sender
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Sender.dll"]