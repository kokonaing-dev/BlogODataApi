# Use official .NET 9 SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.csproj .
RUN dotnet restore

# Copy the rest of the project and build
COPY . .
RUN dotnet publish -c Release -o out

# Use smaller runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/out .

# Expose port
EXPOSE 5030

# Run the API
ENTRYPOINT ["dotnet", "BlogODataApi.dll"]