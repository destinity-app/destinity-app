FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Destinity/Destinity.csproj", "Destinity/"]
RUN dotnet restore "Destinity/Destinity.csproj"
COPY . .
WORKDIR "/src/Destinity"
RUN dotnet build "Destinity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Destinity.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY ["nginx.conf", "/etc/nginx/nginx.conf"]

# Heroku port switch
CMD sed -i -e 's/$PORT/'"$PORT"'/g' /etc/nginx/nginx.conf && nginx -g 'daemon off;'
