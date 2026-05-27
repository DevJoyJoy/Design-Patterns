#Imagem base do .NET
FROM mcr.microsoft.com/dotnet/sdk:9.0

#Define a pasta de trabalho
WORKDIR /Chocotone
#Configurações do proxy
ENV HTTP_PROXY="host.docker.internal:3128"
ENV HTTPS_PROXY="host.docker.internal:3128"

#Copiar o projeto
COPY ./Panetone/*.csproj .
#Baixar as dependências
RUN dotnet restore
#Copiar o código
COPY ./Panetone .

#Comando para rodar quando iniciar
CMD ["dotnet", "run", "--urls=http://0.0.0.0:2327"]

#Infomar a porta a ser usada
EXPOSE 5273