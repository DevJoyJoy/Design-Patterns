FROM mcr.microsoft.com/dotnet/sdk:9.0
 
WORKDIR /nome
ENV HTTP_PROXY="host.docker.internal:3128"
ENV HTTPS_PROXY="host.docker.internal:3128"

COPY ./httyd/*.csproj .
RUN dotnet restore
COPY ./httyd .

CMD ["dotnet", "run"]


EXPOSE 5243