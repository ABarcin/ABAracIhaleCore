#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AB_AracIhaleCore.API/AB_AracIhaleCore.API.csproj", "AB_AracIhaleCore.API/"]
COPY ["AB_AracIhaleCore.DAL/AB_AracIhaleCore.DAL.csproj", "AB_AracIhaleCore.DAL/"]
COPY ["AB_AracIhaleCore.MODEL/AB_AracIhaleCore.MODEL.csproj", "AB_AracIhaleCore.MODEL/"]
COPY ["AB_AracIhaleCore.CORE/AB_AracIhaleCore.CORE.csproj", "AB_AracIhaleCore.CORE/"]
RUN dotnet restore "AB_AracIhaleCore.API/AB_AracIhaleCore.API.csproj"
COPY . .
WORKDIR "/src/AB_AracIhaleCore.API"
RUN dotnet build "AB_AracIhaleCore.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AB_AracIhaleCore.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AB_AracIhaleCore.API.dll"]