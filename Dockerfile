FROM node:20-alpine AS tailwind-build

WORKDIR /app

COPY package.json package-lock.json ./
RUN npm ci

COPY tailwind.config.js postcss.config.js ./
COPY wwwroot/css/input.css ./wwwroot/css/input.css
COPY Views/ ./Views/
COPY wwwroot/js/ ./wwwroot/js/

RUN npx tailwindcss -i ./wwwroot/css/input.css -o ./wwwroot/css/site.css --minify

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS dotnet-build

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . .
COPY --from=tailwind-build /app/wwwroot/css/site.css ./wwwroot/css/site.css

RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS final

WORKDIR /app 

RUN addgroup -S appgroup && adduser -S appuser -G appgroup
USER appuser

COPY --from=dotnet-build /publish .

ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

EXPOSE 8080

ENTRYPOINT ["dotnet", "MatheusWylliamPortfolio.dll"]