FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY ./ClientJoy/*.csproj /app
RUN dotnet restore
COPY ./ClientJoy /app

#Tudo isso serve para que, após construir a estrutura para rodar o projeto, agora eu tenho apenas o básico para rodar, sem precisar criar de novo a estrutura
#Publicar o código para ser compilado em apenas um arquivo
RUN dotnet publish -c Release -o /app/publish

#Iniciar a imagem com os recursos mínimos para rodar o código
FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /app

#Após recompilar, ele vai copiar o projeto para a versão mais básica do .net
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "ClientJoy.dll"]


